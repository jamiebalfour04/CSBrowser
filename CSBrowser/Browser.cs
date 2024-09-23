using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

/*
* Uses Pavel Torgashov's FastColouredSyntaxBox as used in my other projects
* including BRS Editor, HyperWEB, ZPE Editor
* Also uses Balfour's Business Class Library (BBCL) a free to use class library
* for WindowsForms. I did not include a using statement to make it obvious where I used BBCL.
*/

namespace CSBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        #region "Variables"
        //global_path is for save, if the file has been saved already it simply saves to the same page
        private string save_path = "";
        //successPage is for the last successful page that loaded
        private string successPage = "";
        internal BalfoursBusinessClassLibrary.Controls.TabPage TabPage = null;
        internal BrowserWindow browserMain = null;
        #endregion

        #region "Methods"
        private bool isValidUrl(string url)
        {            
            /*
            * Use TryCreate to create the URI rather than simply creating one. Then once we get the result
            * in the uri, we check the scheme. 
            * Similarly, https://msdn.microsoft.com/en-us/library/system.uri.iswellformeduristring.aspx
            */
            Uri uri;
            return (Uri.TryCreate(url, UriKind.Absolute, out uri) && uri.Scheme == Uri.UriSchemeHttp);
        }
        static string global_url = "";
        static string title = "";
        static string global_content = "";
        private void navigate(string url)
        {
            global_url = url;

            Thread t1 = new Thread(new ThreadStart(doWork));
            t1.Start();
            t1.Join();

            urlBox.Text = url;
            this.outputBox.Text = global_content;
            Icon = BalfoursBusinessClassLibrary.Classes.Conversion.BBImageToIcon(urlBox.FavIcon);
            



        }

        private void doWork()
        {
            lock (this)
            {
                //Empty path when we change page
                save_path = "";
                string url = global_url;
                string content = getPageContents(url);
                //Set the page title
                if (content == "-1")
                {
                    content = "This page is invalid.";
                }
                else
                {
                    title = getTitle(content);
                    this.addToHistory(url);
                    successPage = url;

                }
                global_content = content;

            }
            
        }

        private string getPageContents(string url)
        {
            lock (this)
            {
                try
                {
                    //Test the URI is valid first

                    if (!isValidUrl(url))
                        return "-1";

                    WebRequest request = HttpWebRequest.Create(url);
                    HttpWebResponse http = (HttpWebResponse)request.GetResponse();

                    Stream s = http.GetResponseStream();

                    StreamReader reader = new StreamReader(s);

                    string responseFromServer = reader.ReadToEnd();
                    //Favicons are generated from hosts, e.g. google.com not google.com/a/b/
                    Uri u = new Uri(url);
                    Image i = BalfoursBusinessClassLibrary.Classes.Communication.GetFavicon(u.Host, false, false);
                    urlBox.FavIcon = i;
                    
                    // Display the content.
                    return responseFromServer;
                }
                catch (WebException ex)
                {
                    //If there is an error when getting the page
                    string error = "";
                    HttpWebResponse resp = ex.Response as HttpWebResponse;
                    if (resp != null)
                    {
                        error = resp.StatusCode.ToString();
                    }
                    else
                    {
                        error = "You have no connection!";
                    }
                    TabPage.SendPing();

                    MessageBox.Show("There was an error. The error was: " + System.Environment.NewLine + error);
                    return "-1";
                }
            }
            
            

        }

        private string getTitle(string html)
        {
            string regex = @"(?<=<title.*>)([\s\S]*)(?=</title>)";
            Regex ex = new Regex(regex, RegexOptions.IgnoreCase);

            return ex.Match(html).Value.Trim();
        }

        private void addToHistory(string url)
        {
            Properties.Settings.Default.history.Add(url);
            Properties.Settings.Default.Save();
           //updateHistory();
        }

        private void goHome()
        {
            navigate(Properties.Settings.Default.homepage);
        }

        private void saveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, outputBox.Text);
                save_path = sfd.FileName;
            }
        }
        private void updateFavourites()
        {
            favouritesBar.Items.Clear();
            if (!Directory.Exists("favourites"))
                Directory.CreateDirectory("favourites");

            string[] filelist = Directory.GetFiles("favourites", "*.fav");
            foreach (string file in filelist)
            {
                BrowserFavourite f = deserialiseFavourite(file);
                if (f != null)
                {
                    System.Collections.Generic.List<string> l = new System.Collections.Generic.List<string>();
                    l.Add(f.getPath());
                    favouritesBar.AddItem(f.getTitle(), f.getPath(), f.getImage(), "", l);
                }
            }
        }
        private void updateHistory()
        {
            historyBar.Items.Clear();
            foreach (string s in Properties.Settings.Default.history)
            {
                historyBar.Items.Add(s);
            }
        }
       
        private void serialiseFavourite(BrowserFavourite fav, string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            //Create a new file if it does not exist or just write to it
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            //Now store it in binary format
            formatter.Serialize(fs, fav);
            //Close the file stream
            fs.Close();
        }
        private BrowserFavourite deserialiseFavourite(string filename)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                //Open file as a file stream
                FileStream fs = new FileStream(filename, FileMode.Open);
                //Now open it from the binary format
                BrowserFavourite f = (BrowserFavourite)formatter.Deserialize(fs);
                //Close the file stream
                fs.Close();

                return f;
            }
            catch(Exception e)
            {
                return null;
            }
            
        }
        #endregion

        #region "Menu items"         
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browserMain.newTab();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navigate(BalfoursBusinessClassLibrary.Classes.Displays.BBTextInputBox("Please insert a page to go to.", Color.Black, Color.White));
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(save_path == "")
            {
                saveAs();
            }
            else
            {
                System.IO.File.WriteAllText(save_path, outputBox.Text);
            }
            
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
                outputBox.Print();        
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserFavourite f = new BrowserFavourite(urlBox.Text, this.Text, urlBox.FavIcon);
            int pos = 0;
            string filepath = "favourites" + "/fav" + pos + ".fav";
            while (File.Exists(filepath))
            {
                pos++;                
                filepath = "favourites" + "/fav" + pos + ".fav";
            }
                

            serialiseFavourite(f, filepath);
            updateFavourites();
        }
        private void setThisPageToHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.homepage = successPage;
        }
        private void goToHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goHome();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalfoursBusinessClassLibrary.Classes.Displays.BBAboutDialog("CSBrowser", Color.White, Color.Black,
                "Copyright Jamie Balfour", "Version 1.0", this.Icon, "", true, "", "");
        }

        #endregion

        #region "Form main"
        private void favouritesBar_DoubleClick()
        {
            string s = favouritesBar.SelectedItem().HiddenStrings[0];            
            navigate(s);
        }
        private void Browser_Load(object sender, EventArgs e)
        {
            BalfoursBusinessClassLibrary.Classes.BalfoursEnterprises.AdvantageMenu(menuStrip1);
            updateFavourites();
            updateHistory();
            goHome();

        }

        private void urlBox_Button1Clicked()
        {
            navigate(urlBox.Text);
        }

        private void urlBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigate(urlBox.Text);
            }
        }

        private void historyBar_DoubleClick(object sender, EventArgs e)
        {
            if (historyBar.SelectedIndex >= 0)
                navigate(historyBar.SelectedItem.ToString());
        }
        #endregion



        private void favouritesBar_ItemRemoved(BalfoursBusinessClassLibrary.Classes.Structures.LargeListViewItem Item)
        {

        }
        
    }
}
