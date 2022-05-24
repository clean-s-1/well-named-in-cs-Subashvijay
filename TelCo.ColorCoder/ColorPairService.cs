using System;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Service to mapping of pair number to color and color to pair number.
    /// </summary>
    class ColorPairService
    {
        
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        public ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorPair.MinorColorList.Length;
            int majorSize = ColorPair.MajorColorList.Length;

            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
                throw new ArgumentOutOfRangeException($"Argument PairNumber:{pairNumber} is outside the allowed range");
            
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            return new ColorPair() {MajorColor = ColorPair.MajorColorList[majorIndex], MinorColor = ColorPair.MinorColorList[minorIndex]};
        }

        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Array.FindIndex(ColorPair.MajorColorList, 0, (x) => x == pair.MajorColor);
            int minorIndex = Array.FindIndex(ColorPair.MinorColorList, 0, (x) => x == pair.MinorColor);
           
            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException($"Unknown Colors: {pair}");

            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorPair.MinorColorList.Length) + (minorIndex + 1);
        }

    }
}
