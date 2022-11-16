using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            Calculate cal = new Calculate();
            var ran = new Random();
            double a = ran.Next(-1000000, 1000000), b = ran.Next(-1000000, 1000000);
            // Act
            double rez = cal.add(a, b);
            // Assert
            Assert.AreEqual(rez, 0, 2000000);
        }

        [TestMethod]
        public void TestSub()
        {
            // Arrange
            Calculate cal = new Calculate();
            var ran = new Random();
            double a = ran.Next(-1000000, 1000000), b = ran.Next(-1000000, 1000000);
            // Act
            double rez = cal.subtract(a, b);
            // Assert
            Assert.AreEqual(rez, 0, 2000000);
        }

        [TestMethod]
        public void TestMul()
        {
            // Arrange
            Calculate cal = new Calculate();
            var ran = new Random();
            double a = ran.Next(-1000000, 1000000), b = ran.Next(-1000000, 1000000);
            // Act
            double rez = cal.multiply(a, b);
            // Assert
            Assert.AreEqual(rez, 0, 1000000000000);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            Calculate cal = new Calculate();
            var ran = new Random();
            double a = ran.Next(-1000000, 1000000), b = ran.Next(-1000000, 1000000);
            if (b == 0) { b += 1; }
            // Act
            double rez = cal.divide(a, b);
            // Assert
            Assert.AreEqual(rez, 0, 1000000);
        }

        [TestMethod]
        public void TestSin()
        {
            // Arrange
            Calculate cal = new Calculate();
            var ran = new Random();
            double a = ran.Next(-1000000, 1000000);
            // Act
            double rez = cal.sin(a);
            // Assert
            Assert.AreEqual(rez, 0, 1);
        }
    }
}
