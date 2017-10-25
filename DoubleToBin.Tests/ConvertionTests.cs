using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DoubleToBin.ConvertDobleToBin;

namespace DoubleToBin.Tests
{
    [TestClass]
    public class ConvertionTests
    {
        [TestMethod]
        public void NumberInBin_For_Negative_Double_Number()
        {
            string actual = NumberInBin(-255.255);
            string expected = "1100000001101111111010000010100011110101110000101000111101011100";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_Positive_Double_Number()
        {
            string actual = NumberInBin(255.255);
            string expected = "0100000001101111111010000010100011110101110000101000111101011100";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_Zero_Double_Number()
        {
            string actual = NumberInBin(0.0);
            string expected = "0000000000000000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_Minus_Zero_Double_Number()
        {
            string actual = NumberInBin(-0.0);
            string expected = "1000000000000000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_Epsilon_Double_Number()
        {
            string actual = NumberInBin(double.Epsilon);
            string expected = "0000000000000000000000000000000000000000000000000000000000000001";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_NaN_Double_Number()
        {
            string actual = NumberInBin(double.NaN);
            string expected = "1111111111111000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_MinValue_Double_Number()
        {
            string actual = NumberInBin(double.MinValue);
            string expected = "1111111111101111111111111111111111111111111111111111111111111111";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberInBin_For_MaxValue_Double_Number()
        {
            string actual = NumberInBin(double.MaxValue);
            string expected = "0111111111101111111111111111111111111111111111111111111111111111";
            Assert.AreEqual(expected, actual);
        }
    }
}
