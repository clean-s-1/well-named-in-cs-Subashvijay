using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to hold the two colors of color pair
    /// </summary>
    internal class ColorPair
    {
        /// <summary>
        /// data type defined to hold the two colors of color pair
        /// </summary>
        internal Color MajorColor;
        internal Color MinorColor;
        public override string ToString()
        {
            return $"MajorColor:{MajorColor.Name}, MinorColor:{MinorColor.Name}";
        }
    }
}
