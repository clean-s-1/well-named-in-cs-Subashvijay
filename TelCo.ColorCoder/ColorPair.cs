using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to hold the two colors of color pair
    /// </summary>
    internal class ColorPair
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public  static readonly  Color[] MajorColorList = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public  static  readonly Color[] MinorColorList  = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

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
