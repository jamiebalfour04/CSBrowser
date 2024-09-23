using System;
using System.Windows.Forms;
using BalfoursBusinessClassLibrary;

namespace CSBrowser
{
    public partial class BrowserWindow : Form
    {
        public BrowserWindow()
        {
            InitializeComponent();
        }

        private void BrowserWindow_Load(object sender, EventArgs e)
        {
            tabControlWithOrb1.Theme = BalfoursBusinessClassLibrary.Controls.TabControlWithOrb.ThemeType.GlassTheme;
            newTab();
        }
        public void newTab()
        {
            Browser b = new Browser();
            b.TabPage = tabControlWithOrb1.TabPages.Add(b);
            b.browserMain = this;
        }
    }
}
