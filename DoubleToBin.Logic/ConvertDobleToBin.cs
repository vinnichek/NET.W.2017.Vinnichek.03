using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleToBin
{
    public class ConvertDobleToBin
    {
        /// <summary>
        /// Converts number to bin.
        /// </summary>
        /// <param name="number">Number.</param>
        /// <returns>Number in bin.</returns>
        public static string NumberInBin(double number)
        {
            BitArray bits = new BitArray(BitConverter.GetBytes(number));
            return ToString(bits);
        }

        /// <summary>
        /// Converts to string
        /// </summary>
        /// <param name="array">Array of bits.</param>
        /// <returns>String of bits.</returns>
        private static string ToString(BitArray array)
        {
            StringBuilder bitsString = new StringBuilder(array.Length);
            for (int i = array.Length - 1; i >= 0; i--)
                bitsString.Append(array[i] ? '1' : '0');
            return bitsString.ToString();
        }
    }
}
