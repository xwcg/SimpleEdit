using System;
using System.Collections.Generic;
using System.Text;
using SimpleEditFileHandler;
using System.Windows.Forms;

namespace SF_rtf
{
    public class Main : SEFileHandler
    {
        private string filecontent = "";
        private RichTextBox rtb = new RichTextBox();

        #region SEFileHandler Members

        public string[] fileExtensions
        {
            get
            {
                return new string[] { ".rtf" };
            }
        }

        public string Content
        {
            get
            {
                return filecontent;
            }
        }

        public bool isRtf
        {
            get
            {
                return true;
            }
        }

        public bool Load( string path )
        {
            try
            {
                rtb.LoadFile(path);
                filecontent = rtb.Rtf;
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool Save( string path, string content )
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SEPlugin Members

        public string PluginName
        {
            get
            {
                return "Rich Text File Handler";
            }
        }

        public string Version
        {
            get
            {
                return "1.0.0";
            }
        }

        public string Author
        {
            get
            {
                return "Michael Schwarz";
            }
        }

        public string Website
        {
            get
            {
                return "";
            }
        }

        public string Description
        {
            get
            {
                return "Imports .rtf documents";
            }
        }

        public void Dispose()
        {
            rtb.Dispose();
            rtb = null;

            filecontent = "";
        }

        #endregion
    }
}
