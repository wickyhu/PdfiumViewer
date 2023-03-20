using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PdfiumViewer
{
    /// <summary>
    /// 
    /// </summary>
    public struct PdfCharacterInformation
    {
        /// <summary>
        /// 
        /// </summary>
        public int Page { get; }
        /// <summary>
        /// 
        /// </summary>
        public int Offset { get; }
        /// <summary>
        /// 
        /// </summary>
        public double FontSize { get; }
        /// <summary>
        /// 
        /// </summary>
        public char Character { get; }
        /// <summary>
        /// 
        /// </summary>
        public RectangleF Bounds { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="offset"></param>
        /// <param name="character"></param>
        /// <param name="fontSize"></param>
        /// <param name="bounds"></param>
        public PdfCharacterInformation(int page, int offset, char character, double fontSize, RectangleF bounds)
        {
            Page = page;
            Offset = offset;
            FontSize = fontSize;
            Bounds = bounds;
            Character = character;
        }

    }
}
