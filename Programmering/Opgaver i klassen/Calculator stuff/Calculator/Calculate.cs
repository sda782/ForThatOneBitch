using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculate
    {
        /// <summary>
        /// This method adds two numbers and returns the result
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// This method returns the result of two subtracted numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Multiplies two integers and returns an int
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// Divides two integers and returns a double
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
