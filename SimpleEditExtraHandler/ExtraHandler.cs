using System;
using System.Collections.Generic;
using System.Text;
using SimpleEditPluginInterface;

namespace SimpleEditExtraHandler
{
    public interface SEExtra : SEPlugin
    {
        /// <summary>
        /// Do the transform.
        /// </summary>
        /// <param name="input">string to be transformed</param>
        /// <returns>Transformed string</returns>
        string Do( string input );
    }
}
