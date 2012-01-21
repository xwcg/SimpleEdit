using System;
using System.Collections.Generic;
using System.Text;
using SimpleEditExtraHandler;

namespace SX_Uppercase
{
    public class Main : SEExtra
    {
        #region SEExtra Members

        public string Do( string input )
        {
            return input.ToUpper();
        }

        #endregion

        #region SEPlugin Members

        public string PluginName
        {
            get
            {
                return "UPPERCASE";
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
                return "Turns all selected letters into CAPITAL letters.";
            }
        }

        public void Dispose()
        {
            return;
        }

        #endregion
    }
}
