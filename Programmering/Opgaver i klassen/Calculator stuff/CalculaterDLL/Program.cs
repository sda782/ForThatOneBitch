using System;
using Calculator;


namespace CalculaterDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double a = Calculate.Add(2, 3);
            double b = Calculate.Subtract(10, 2);
            double c = Calculate.Divide(10, 400);
            double d = Calculate.Multiply(10, 10);

            Console.WriteLine("2 + 3 = " + a);
            Console.WriteLine("10 - 2 = " + b);
            Console.WriteLine("10 / 400 = " + c);
            Console.WriteLine("10 * 10 = " + d);
        }
    }
}
