using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor.Logic
{
    public class GreatestCommonDivisor
    {

        #region PublicMethods

        #region Public Euclid Methods
        /// <summary>
        /// Finds GCD using Euclid Method for two numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int EuclidMethod(int firstNumber, int secondNumber)
        {
            int gcd = HelperForEuclidMethod(firstNumber, secondNumber);
            return gcd;
        }

        /// <summary>
        /// Finds GCD using Euclid Method for array.
        /// </summary>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for all numbers from array. </returns>
        public static int EuclidMethod(params int[] array)
        {
            ArrayChecker(array);
            int gcd = HelperForEuclidMethod(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                gcd = EuclidMethod(gcd, array[i]);
            }
            return gcd;
        }
    #endregion

        #region Public Stein Methods
        /// <summary>
        /// Finds GCD using Stein Method for two numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int SteinMethod(int firstNumber, int secondNumber)
        {
            int gcd = HelperForEuclidMethod(firstNumber, secondNumber);
            return gcd;
        }

        /// <summary>
        /// Finds GCD using Euclid Method for two numbers.
        /// </summary>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for all numbers from array. </returns>
        public static int SteinMethod(params int[] array)
        {
            ArrayChecker(array);
            int gcd = HelperForSteinMethod(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                gcd = SteinMethod(gcd, array[i]);
            }
            return gcd;
        }
    #endregion

        #endregion

        #region Private Methods

        #region Private Euclid Methods

        private static int HelperForEuclidMethod(int firstNumber, int secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            if (firstNumber == 0) return firstNumber;
            if (secondNumber == 0) return secondNumber;

            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber - secondNumber;
                }
                else
                {
                    secondNumber = secondNumber - firstNumber;
                }
            }
            return firstNumber;
        }

        private static int HelperForEuclidMethod(out long time, int firstNumber, int secondNumber)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = EuclidMethod(firstNumber, secondNumber);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;

            return gcd;
        }

        private static int HelperForEuclidMethod(out long time, params int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = EuclidMethod(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;

            return gcd;
        }
        #endregion

        #region Private Stein Methods
        private static int HelperForSteinMethod(int firstNumber, int secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            if (firstNumber == secondNumber) return firstNumber;
            if (firstNumber == 0) return firstNumber;
            if (secondNumber == 0) return secondNumber;

            if ((~firstNumber & 1) != 0)
            {
                if ((secondNumber & 1) != 0)
                    return HelperForSteinMethod(firstNumber >> 1, secondNumber);
                else
                    return HelperForSteinMethod(firstNumber >> 1, secondNumber >> 1) << 1;
            }

            if ((~secondNumber & 1) != 0)
                return HelperForSteinMethod(firstNumber, secondNumber >> 1);

            if (firstNumber > secondNumber)
                return HelperForSteinMethod((firstNumber - secondNumber) >> 1, secondNumber);

            int gcd = HelperForSteinMethod((secondNumber - firstNumber) >> 1, firstNumber);

            return gcd;
        }

        private static int HelperForSteinMethod(out long time, int firstNumber, int secondNumber)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = SteinMethod(firstNumber, secondNumber);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;

            return gcd;
        }

        private static int HelperForSteinMethod(out long time, params int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = SteinMethod(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;

            return gcd;
        }
        #endregion

        private static void ArrayChecker(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            if (array.Length == 1) 
            {
                throw new ArgumentException("Need at least two elements.");
            }
        }

        #endregion
    }
}
