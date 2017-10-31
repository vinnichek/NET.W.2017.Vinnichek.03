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
        /// Finds GCD using Euclid Method for three numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <param name="thirdNumber">Second int number. </param>
        /// <returns>GCD for three numbers. </returns>
        public static int EuclidMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            int gcd = HelperForEuclidMethod(firstNumber, secondNumber);
            return HelperForEuclidMethod(gcd, thirdNumber);
        }

        /// <summary>
        /// Finds GCD using Euclid Method for four numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <param name="thirdNumber">Second int number. </param>
        /// <param name="fourthNumber">Second int number. </param>
        /// <returns>GCD for four numbers. </returns>
        public static int EuclidMethod(int firstNumber, int secondNumber, int thirdNumber, int foursNumber)
        {
            int gcd = HelperForEuclidMethod(firstNumber, secondNumber);
            gcd = HelperForEuclidMethod(gcd, thirdNumber);
            return HelperForEuclidMethod(gcd, foursNumber);
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

        /// <summary>
        /// Finds GCD using Euclid Method for two numbers.
        /// </summary>
        /// <param name="time">Method for time. </param>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int EuclidMethod(out long time, int firstNumber, int secondNumber)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = EuclidMethod(firstNumber, secondNumber);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
            return gcd;
        }

        /// <summary>
        /// Finds GCD using Euclid Method for two numbers.
        /// </summary>
        /// <param name="time">Method for time. </param>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int EuclidMethod(out long time, params int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = EuclidMethod(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
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
        /// Finds GCD using Stein Method for three numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <param name="thirdNumber">Second int number. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int SteinMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            int gcd = HelperForEuclidMethod(firstNumber, secondNumber);
            return HelperForEuclidMethod(gcd, thirdNumber);
        }

        /// <summary>
        /// Finds GCD using Stein Method for four numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <param name="thirdNumber">Second int number. </param>
        /// <param name="foursNumber">Second int number. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int SteinMethod(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            int gcd = HelperForEuclidMethod(firstNumber, secondNumber);
            gcd = HelperForEuclidMethod(gcd, thirdNumber);
            return HelperForEuclidMethod(gcd, fourthNumber);
        }

        /// <summary>
        /// Finds GCD using Stein Method for array of numbers.
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

        /// <summary>
        /// Finds GCD using Stein Method for two numbers.
        /// </summary>
        /// <param name="time">Method for time. </param>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <returns>GCD for two numbers. </returns>
        private static int SteinMethod(out long time, int firstNumber, int secondNumber)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = SteinMethod(firstNumber, secondNumber);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
            return gcd;
        }

        /// <summary>
        /// Finds GCD using Stein Method for two numbers.
        /// </summary>
        /// <param name="time">Method for time. </param>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for array of int numbers. </returns>
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

        #endregion

        #region Private Methods
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
