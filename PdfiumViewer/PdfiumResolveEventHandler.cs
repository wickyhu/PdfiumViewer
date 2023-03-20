using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    /// <summary>
    /// 
    /// </summary>
    public class PdfiumResolveEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public string PdfiumFileName { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void PdfiumResolveEventHandler(object sender, PdfiumResolveEventArgs e);
}
