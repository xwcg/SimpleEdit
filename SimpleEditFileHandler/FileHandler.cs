using System;
using System.Collections.Generic;
using System.Text;
using SimpleEditPluginInterface;

namespace SimpleEditFileHandler
{
    public interface SEFileHandler : SEPlugin
    {
        /// <summary>
        /// Lists the file extensions this plugin can handle
        /// </summary>
        string[] fileExtensions
        {
            get;
        }

        /// <summary>
        /// Returns the content of the document. Refer to isRtf for proper handling.
        /// </summary>
        string Content
        {
            get;
        }

        /// <summary>
        /// Is the document a rich text document
        /// </summary>
        bool isRtf
        {
            get;
        }

        /// <summary>
        /// Load a file. Returns success of loading.
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>true of success, false on failure</returns>
        bool Load( string path );

        /// <summary>
        /// Save a file. Returns success of save operation.
        /// </summary>
        /// <param name="path">File path</param>
        /// <param name="content">Content of file</param>
        /// <returns>true of success, false on failure</returns>
        bool Save( string path, string content );
    }
}
