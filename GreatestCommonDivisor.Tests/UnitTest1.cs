using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GreatestCommonDivisor.Logic.GreatestCommonDivisor;

namespace GreatestCommonDivisor.Tests
{
    [TestClass]
    public class GCDTests
    {
        #region Tests For EuclidMethod
        [TestMethod]
        public void EuclidMethod_For_Positive_Numbers()
        {
            int actual = EuclidMethod(5, 10);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidMethod_For_Positive_And_Zero_Numbers()
        {
            int actual = EuclidMethod(5, 0);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidMethod_For_Positive_And_Negative_Numbers()
        {
            int actual = EuclidMethod(-5, 3);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidMethod_For_Four_Numbers()
        {
            int actual = SteinMethod(6, 3, 9, 12);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EuclidMethod_For_Null_Array_Throw_ArgumentNullException()
        {
            int actual = SteinMethod(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclidMethod_For_Empty_Array_Throw_ArgumentException()
        {
            int actual = SteinMethod();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclidMethod_For_One_Element_In_Array_Throw_ArgumentException()
        {
            int actual = SteinMethod(3);
        }
        #endregion

        #region Tests For SteinMethod
        [TestMethod]
        public void SteinMethod_For_Positive_Numbers()
        {
            int actual = SteinMethod(5, 10);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinMethod_For_Positive_And_Zero_Numbers()
        {
            int actual = SteinMethod(5, 0);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinMethod_For_Positive_And_Negative_Numbers()
        {
            int actual = SteinMethod(-5, 3);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinMethod_For_Three_Numbers()
        {
            int actual = SteinMethod(6, 3, 9);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SteinMethod_For_Null_Array_Throw_ArgumentNullException()
        {
            int actual = SteinMethod(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SteinMethod_For_Empty_Array_Throw_ArgumentException()
        {
            int actual = SteinMethod();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SteinMethod_For_One_Element_In_Array_Throw_ArgumentException()
        {
            int actual = SteinMethod(3);
        }
        #endregion
    }
}
