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

        /// <summary>
        /// Finds GCD using Euclid Method for three numbers.
        /// </summary>
        /// <param name="firstNumber">First int number. </param>
        /// <param name="secondNumber">Second int number. </param>
        /// <param name="thirdNumber">Second int number. </param>
        /// <returns>GCD for three numbers. </returns>
        public static int EuclidMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            int gcd = EuclidMethod(firstNumber, secondNumber);
            return EuclidMethod(gcd, thirdNumber);
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
            int gcd = EuclidMethod(firstNumber, secondNumber);
            gcd = EuclidMethod(gcd, thirdNumber);
            return EuclidMethod(gcd, foursNumber);
        }

        /// <summary>
        /// Finds GCD using Euclid Method for array.
        /// </summary>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for all numbers from array. </returns>
        public static int EuclidMethod(params int[] array)
        {
            ArrayChecker(array);
            int gcd = EuclidMethod(array[0], array[1]);
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
        public static int EuclidMethod(out TimeSpan time, int firstNumber, int secondNumber) => Calculate(() => EuclidMethod(firstNumber, secondNumber), out time);

        /// <summary>
        /// Finds GCD using Euclid Method for two numbers.
        /// </summary>
        /// <param name="time">Method for time. </param>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for two numbers. </returns>
        public static int EuclidMethod(out TimeSpan time, params int[] array) => Calculate(() => EuclidMethod(array), out time);

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
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            if (firstNumber == secondNumber) return firstNumber;
            if (firstNumber == 0) return firstNumber;
            if (secondNumber == 0) return secondNumber;

            if ((~firstNumber & 1) != 0)
            {
                if ((secondNumber & 1) != 0)
                    return SteinMethod(firstNumber >> 1, secondNumber);
                else
                    return SteinMethod(firstNumber >> 1, secondNumber >> 1) << 1;
            }

            if ((~secondNumber & 1) != 0)
                return SteinMethod(firstNumber, secondNumber >> 1);

            if (firstNumber > secondNumber)
                return SteinMethod((firstNumber - secondNumber) >> 1, secondNumber);

            int gcd = SteinMethod((secondNumber - firstNumber) >> 1, firstNumber);

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
            int gcd = SteinMethod(firstNumber, secondNumber);
            return SteinMethod(gcd, thirdNumber);
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
            int gcd = SteinMethod(firstNumber, secondNumber);
            gcd = SteinMethod(gcd, thirdNumber);
            return SteinMethod(gcd, fourthNumber);
        }

        /// <summary>
        /// Finds GCD using Stein Method for array of numbers.
        /// </summary>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for all numbers from array. </returns>
        public static int SteinMethod(params int[] array)
        {
            ArrayChecker(array);
            int gcd = SteinMethod(array[0], array[1]);
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
        public static int SteinMethod(out TimeSpan time, int firstNumber, int secondNumber) => Calculate(() => SteinMethod(firstNumber, secondNumber), out time);

        /// <summary>
        /// Finds GCD using Stein Method for two numbers.
        /// </summary>
        /// <param name="time">Method for time. </param>
        /// <param name="array">Array of int numbers. </param>
        /// <returns>GCD for array of int numbers. </returns>
        public static int SteinMethod(out TimeSpan time, params int[] array) => Calculate(() => SteinMethod(array), out time);

        #endregion

        #endregion

        #region Private Methods
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

        private static int Calculate(Func<int> operation, out TimeSpan time)
        {
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();

            int gcd = operation();

            stopwatch.Stop();
            time = stopwatch.Elapsed;

            return gcd;
        }
        #endregion
    }
}
