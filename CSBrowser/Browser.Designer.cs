namespace CSBrowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.setThisPageToHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.urlBox = new BalfoursBusinessClassLibrary.Controls.CrossedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Sidebar = new System.Windows.Forms.TabControl();
            this.favouritesTab = new System.Windows.Forms.TabPage();
            this.favouritesBar = new BalfoursBusinessClassLibrary.Controls.LargeButtonListView();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.historyBar = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.browserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.favouritesTab.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(257, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(293, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFavouritesToolStripMenuItem,
            this.toolStripSeparator3,
            this.setThisPageToHomepageToolStripMenuItem,
            this.goToHomepageToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // saveToFavouritesToolStripMenuItem
            // 
            this.saveToFavouritesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToFavouritesToolStripMenuItem.Image")));
            this.saveToFavouritesToolStripMenuItem.Name = "saveToFavouritesToolStripMenuItem";
            this.saveToFavouritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.saveToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(451, 38);
            this.saveToFavouritesToolStripMenuItem.Text = "Save to favourites";
            this.saveToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.saveToFavouritesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(448, 6);
            // 
            // setThisPageToHomepageToolStripMenuItem
            // 
            this.setThisPageToHomepageToolStripMenuItem.Name = "setThisPageToHomepageToolStripMenuItem";
            this.setThisPageToHomepageToolStripMenuItem.Size = new System.Drawing.Size(451, 38);
            this.setThisPageToHomepageToolStripMenuItem.Text = "Set this page to homepage";
            this.setThisPageToHomepageToolStripMenuItem.Click += new System.EventHandler(this.setThisPageToHomepageToolStripMenuItem_Click);
            // 
            // goToHomepageToolStripMenuItem
            // 
            this.goToHomepageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goToHomepageToolStripMenuItem.Image")));
            this.goToHomepageToolStripMenuItem.Name = "goToHomepageToolStripMenuItem";
            this.goToHomepageToolStripMenuItem.Size = new System.Drawing.Size(451, 38);
            this.goToHomepageToolStripMenuItem.Text = "Go to homepage";
            this.goToHomepageToolStripMenuItem.Click += new System.EventHandler(this.goToHomepageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // browserPanel
            // 
            this.browserPanel.ColumnCount = 1;
            this.browserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.browserPanel.Controls.Add(this.outputBox, 0, 1);
            this.browserPanel.Controls.Add(this.urlBox, 0, 0);
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(493, 3);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Padding = new System.Windows.Forms.Padding(5);
            this.browserPanel.RowCount = 2;
            this.browserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.browserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.browserPanel.Size = new System.Drawing.Size(721, 644);
            this.browserPanel.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.AutoScrollMinSize = new System.Drawing.Size(43, 29);
            this.outputBox.BackBrush = null;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.CharHeight = 29;
            this.outputBox.CharWidth = 16;
            this.outputBox.CommentPrefix = null;
            this.outputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.outputBox.IsReplaceMode = false;
            this.outputBox.Language = FastColoredTextBoxNS.Language.HTML;
            this.outputBox.LeftBracket = '<';
            this.outputBox.LeftBracket2 = '(';
            this.outputBox.Location = new System.Drawing.Point(8, 72);
            this.outputBox.Name = "outputBox";
            this.outputBox.Paddings = new System.Windows.Forms.Padding(0);
            this.outputBox.RightBracket = '>';
            this.outputBox.RightBracket2 = ')';
            this.outputBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.outputBox.Size = new System.Drawing.Size(705, 564);
            this.outputBox.TabIndex = 1;
            this.outputBox.Zoom = 100;
            // 
            // urlBox
            // 
            this.urlBox.AcceptedInputs = BalfoursBusinessClassLibrary.Controls.CrossedTextBox.InputsAccepted.All;
            this.urlBox.AcceptsReturn = false;
            this.urlBox.AcceptsTab = false;
            this.urlBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.urlBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.urlBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlBox.BackColor = System.Drawing.Color.White;
            this.urlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlBox.Button1BackColour = System.Drawing.Color.Transparent;
            this.urlBox.Button1Enabled = true;
            this.urlBox.Button1Image = ((System.Drawing.Image)(resources.GetObject("urlBox.Button1Image")));
            this.urlBox.Button1Tooltip = null;
            this.urlBox.Button2BackColour = System.Drawing.Color.Transparent;
            this.urlBox.Button2Enabled = true;
            this.urlBox.Button2Image = ((System.Drawing.Image)(resources.GetObject("urlBox.Button2Image")));
            this.urlBox.Button2Tooltip = null;
            this.urlBox.Button3BackColour = System.Drawing.Color.Transparent;
            this.urlBox.Button3Enabled = true;
            this.urlBox.Button3Image = ((System.Drawing.Image)(resources.GetObject("urlBox.Button3Image")));
            this.urlBox.Button3Tooltip = null;
            this.urlBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.urlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlBox.FavIcon = null;
            this.urlBox.HideSelection = true;
            this.urlBox.InitialBackColour = System.Drawing.Color.White;
            this.urlBox.InitialColour = System.Drawing.Color.Gray;
            this.urlBox.LabelTextFont = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlBox.LabelTextForeColour = System.Drawing.SystemColors.ControlText;
            this.urlBox.LabelTextString = "Browse the web";
            this.urlBox.LabelTextVisible = false;
            this.urlBox.Location = new System.Drawing.Point(13, 13);
            this.urlBox.Margin = new System.Windows.Forms.Padding(8);
            this.urlBox.MaxLength = 32767;
            this.urlBox.Multiline = false;
            this.urlBox.Name = "urlBox";
            this.urlBox.PasswordChar = '\0';
            this.urlBox.PingBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(100)))));
            this.urlBox.ReturnText = null;
            this.urlBox.Scrollbars = System.Windows.Forms.ScrollBars.None;
            this.urlBox.SecondaryColour = System.Drawing.Color.Black;
            this.urlBox.SelectedText = "";
            this.urlBox.SelectionLength = 0;
            this.urlBox.SelectionStart = 0;
            this.urlBox.ShowButton1 = true;
            this.urlBox.ShowFavIcon = true;
            this.urlBox.ShowLabelText = false;
            this.urlBox.ShowSeperator1 = true;
            this.urlBox.ShowSeperator2 = false;
            this.urlBox.ShowSpellcheck = false;
            this.urlBox.Size = new System.Drawing.Size(695, 48);
            this.urlBox.TabIndex = 2;
            this.urlBox.UseSystemPasswordChar = false;
            this.urlBox.Button1Clicked += new BalfoursBusinessClassLibrary.Controls.CrossedTextBox.Button1ClickedEventHandler(this.urlBox_Button1Clicked);
            this.urlBox.KeyUp += new BalfoursBusinessClassLibrary.Controls.CrossedTextBox.KeyUpEventHandler(this.urlBox_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 490F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Sidebar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.browserPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1217, 650);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Sidebar
            // 
            this.Sidebar.Controls.Add(this.favouritesTab);
            this.Sidebar.Controls.Add(this.historyTab);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sidebar.Location = new System.Drawing.Point(3, 3);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.SelectedIndex = 0;
            this.Sidebar.Size = new System.Drawing.Size(484, 644);
            this.Sidebar.TabIndex = 6;
            // 
            // favouritesTab
            // 
            this.favouritesTab.Controls.Add(this.favouritesBar);
            this.favouritesTab.Location = new System.Drawing.Point(8, 39);
            this.favouritesTab.Name = "favouritesTab";
            this.favouritesTab.Padding = new System.Windows.Forms.Padding(3);
            this.favouritesTab.Size = new System.Drawing.Size(468, 597);
            this.favouritesTab.TabIndex = 0;
            this.favouritesTab.Text = "Favourites";
            this.favouritesTab.UseVisualStyleBackColor = true;
            // 
            // favouritesBar
            // 
            this.favouritesBar.BackColor = System.Drawing.Color.White;
            this.favouritesBar.BasePanel = null;
            this.favouritesBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favouritesBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favouritesBar.FontDescription = null;
            this.favouritesBar.ImageSize = new System.Drawing.Size(52, 44);
            this.favouritesBar.ItemBack = System.Drawing.Color.White;
            this.favouritesBar.ItemSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.favouritesBar.Location = new System.Drawing.Point(3, 3);
            this.favouritesBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.favouritesBar.Name = "favouritesBar";
            this.favouritesBar.SelectionColour1 = System.Drawing.SystemColors.MenuHighlight;
            this.favouritesBar.SelectionColour2 = System.Drawing.SystemColors.MenuHighlight;
            this.favouritesBar.ShowDeleteButtonOnSelect = true;
            this.favouritesBar.ShowTitleLabel = false;
            this.favouritesBar.ShowTopButton = false;
            this.favouritesBar.Size = new System.Drawing.Size(462, 591);
            this.favouritesBar.TabIndex = 0;
            this.favouritesBar.TitleLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouritesBar.TitleLabelText = "LargeButtonListView";
            this.favouritesBar.TopButtonImage = ((System.Drawing.Image)(resources.GetObject("favouritesBar.TopButtonImage")));
            this.favouritesBar.UseInverseAdding = false;
            this.favouritesBar.DoubleClick += new BalfoursBusinessClassLibrary.Controls.LargeButtonListView.DoubleClickEventHandler(this.favouritesBar_DoubleClick);
            this.favouritesBar.ItemRemoved += new BalfoursBusinessClassLibrary.Controls.LargeButtonListView.ItemRemovedEventHandler(this.favouritesBar_ItemRemoved);
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.historyBar);
            this.historyTab.Location = new System.Drawing.Point(8, 39);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(468, 597);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // historyBar
            // 
            this.historyBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyBar.FormattingEnabled = true;
            this.historyBar.ItemHeight = 25;
            this.historyBar.Location = new System.Drawing.Point(3, 3);
            this.historyBar.Name = "historyBar";
            this.historyBar.Size = new System.Drawing.Size(462, 591);
            this.historyBar.TabIndex = 0;
            this.historyBar.DoubleClick += new System.EventHandler(this.historyBar_DoubleClick);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Browser";
            this.Text = "Blank page";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.browserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.favouritesTab.ResumeLayout(false);
            this.historyTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel browserPanel;
        private FastColoredTextBoxNS.FastColoredTextBox outputBox;
        private BalfoursBusinessClassLibrary.Controls.CrossedTextBox urlBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl Sidebar;
        private System.Windows.Forms.TabPage favouritesTab;
        private System.Windows.Forms.TabPage historyTab;
        private BalfoursBusinessClassLibrary.Controls.LargeButtonListView favouritesBar;
        private System.Windows.Forms.ToolStripMenuItem saveToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem setThisPageToHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToHomepageToolStripMenuItem;
        private System.Windows.Forms.ListBox historyBar;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

