using System;
using System.Collections.Generic;
using System.Text;
using SimpleEditExtraHandler;

namespace SX_Lowercase
{
    public class Main : SEExtra
    {
        #region SEExtra Members

        public string Do( string input )
        {
            return input.ToLower();
        }

        #endregion

        #region SEPlugin Members

        public string PluginName
        {
            get
            {
                return "lowercase";
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
                return "Turns all selected letters into lowercase letters.";
            }
        }

        public void Dispose()
        {
            return;
        }

        #endregion
    }
}
