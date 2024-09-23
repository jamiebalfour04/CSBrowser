namespace CSBrowser
{
    partial class BrowserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserWindow));
            this.tabControlWithOrb1 = new BalfoursBusinessClassLibrary.Controls.TabControlWithOrb();
            this.SuspendLayout();
            // 
            // tabControlWithOrb1
            // 
            this.tabControlWithOrb1.AddDefaultContextItemsAfter = false;
            this.tabControlWithOrb1.AddDefaultContextItemsBefore = false;
            this.tabControlWithOrb1.AddRecentAndFavouritesToMenu = false;
            this.tabControlWithOrb1.BackColor = System.Drawing.Color.Black;
            this.tabControlWithOrb1.BackHighColor = System.Drawing.Color.Transparent;
            this.tabControlWithOrb1.BackLowColor = System.Drawing.Color.Transparent;
            this.tabControlWithOrb1.CustomOrbMenu = null;
            this.tabControlWithOrb1.DefaultOrbOption = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.OrbRaiseOption.EventMode;
            this.tabControlWithOrb1.DefaultSoftwareColour = System.Drawing.Color.White;
            this.tabControlWithOrb1.DelayDrag = true;
            this.tabControlWithOrb1.DeleteTabsMode = false;
            this.tabControlWithOrb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWithOrb1.DropDownFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabControlWithOrb1.DropDownItemList = null;
            this.tabControlWithOrb1.FontBoldOnSelect = false;
            this.tabControlWithOrb1.LeftOffset = 3;
            this.tabControlWithOrb1.LinkedBottomBar = null;
            this.tabControlWithOrb1.LinkedForm = this;
            this.tabControlWithOrb1.LinkedGlassControl1 = null;
            this.tabControlWithOrb1.LinkedToolbar = null;
            this.tabControlWithOrb1.LinkedTopBar = null;
            this.tabControlWithOrb1.Location = new System.Drawing.Point(0, 0);
            this.tabControlWithOrb1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlWithOrb1.MenuRenderer = null;
            this.tabControlWithOrb1.Name = "tabControlWithOrb1";
            this.tabControlWithOrb1.OrbGlowOnHover = true;
            this.tabControlWithOrb1.OrbImage = ((System.Drawing.Image)(resources.GetObject("tabControlWithOrb1.OrbImage")));
            this.tabControlWithOrb1.OrbTooltip = "Click this button to get started";
            this.tabControlWithOrb1.OrbVisible = false;
            this.tabControlWithOrb1.OrbWidth = 28;
            this.tabControlWithOrb1.OverrideTheme = false;
            this.tabControlWithOrb1.PingSpeed = 500F;
            this.tabControlWithOrb1.RegistryLocation = "Software\\Balfour Enterprises";
            this.tabControlWithOrb1.SetBackLowColorWithTheme = true;
            this.tabControlWithOrb1.SetFormTextAutomatically = false;
            this.tabControlWithOrb1.ShowAddNewBrowserButton = false;
            this.tabControlWithOrb1.Size = new System.Drawing.Size(534, 523);
            this.tabControlWithOrb1.SuiteName = "";
            this.tabControlWithOrb1.TabApplicationWebsite = null;
            this.tabControlWithOrb1.TabBackHighAlpha = 0;
            this.tabControlWithOrb1.TabCloseButtonImage = null;
            this.tabControlWithOrb1.TabCloseButtonImageDisabled = null;
            this.tabControlWithOrb1.TabCloseButtonImageHot = null;
            this.tabControlWithOrb1.TabControlIcon = null;
            this.tabControlWithOrb1.TabIndex = 0;
            this.tabControlWithOrb1.TabPingColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(100)))));
            this.tabControlWithOrb1.TabSpecification = "Document";
            this.tabControlWithOrb1.Theme = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.ThemeType.GlassTheme;
            this.tabControlWithOrb1.ThemeCustomFilename = "";
            this.tabControlWithOrb1.TopSeparator = false;
            this.tabControlWithOrb1.UseCircularOrb = true;
            this.tabControlWithOrb1.UseCustomColours = true;
            this.tabControlWithOrb1.UseDragOnBar = false;
            this.tabControlWithOrb1.UseGenericBBTheme = false;
            this.tabControlWithOrb1.UseInvertColourOnDropDownButtonOnGlassTheme = false;
            this.tabControlWithOrb1.UseThemes = true;
            this.tabControlWithOrb1.WebsiteForThemeDownload = "http://www.jamiebalfour.co.uk/Business/Software/Files/Theme.bbt";
            // 
            // BrowserWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(534, 523);
            this.Controls.Add(this.tabControlWithOrb1);
            this.KeyPreview = true;
            this.Name = "BrowserWindow";
            this.Text = "Blade Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrowserWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal BalfoursBusinessClassLibrary.Controls.TabControlWithOrb tabControlWithOrb1;
    }
}