using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEditPluginInterface
{
    public interface SEPlugin
    {
        string PluginName
        {
            get;
        }
        string Version
        {
            get;
        }
        string Author
        {
            get;
        }
        string Website
        {
            get;
        }
        string Description
        {
            get;
        }

        void Dispose();
    }
}
