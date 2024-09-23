using System;
using System.Runtime.Serialization;
using System.Drawing;

namespace CSBrowser
{
    [Serializable]
    class BrowserFavourite
    {
        private Image icon;
        private string path;
        private string title;


        public BrowserFavourite(string path, string title, Image ico)
        {
            this.path = path;
            this.icon = ico;
            this.title = title;
        }
        public Image getImage()
        {
            return icon;
        }
        public string getTitle()
        {
            return title;
        }
        public string getPath()
        {
            return path;
        }
    }
}
