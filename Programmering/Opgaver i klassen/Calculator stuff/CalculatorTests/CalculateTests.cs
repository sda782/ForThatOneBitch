using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int num1 = 10;
            int num2 = 40;

            int expected = num1 + num2;

            int real = Calculate.Add(num1, num2);

            Assert.AreEqual(real, expected);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            int num1 = 55;
            int num2 = 23;

            int expected = num1 - num2;

            int real = Calculate.Subtract(num1, num2);

            Assert.AreEqual(real, expected);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int num1 = 4;
            int num2 = 9;

            int expected = num1 * num2;

            int real = Calculate.Multiply(num1, num2);

            Assert.AreEqual(real, expected);
        }

        [TestMethod()]
        public void DivideTest()
        {
            int num1 = 14;
            int num2 = 99;

            int expected = num1 / num2;

            double real = Calculate.Divide(num1, num2);

            Assert.AreEqual(real, expected);
        }
    }
}