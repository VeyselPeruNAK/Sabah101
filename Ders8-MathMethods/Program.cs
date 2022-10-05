using System;

namespace Ders8_MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int mutlak7 = Math.Abs(-7);
            double cos45 = Math.Cos(45);
            Console.WriteLine(mutlak7);
            Console.WriteLine(cos45);
            Console.WriteLine(Math.Sin(45));
            Console.WriteLine(Math.Tan(45));
            Console.WriteLine(Math.Max(4, 5));
            Console.WriteLine(Math.Min(4, 5));
            Console.WriteLine(Math.Pow(2, 5));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Log(100));
            Console.WriteLine(Math.Exp(4));
            Console.WriteLine(Math.Log10(5));

            double[] numbers = {-1, 0, .105, .5, .798, 1, 4, 6.9, 10, 50,
                          100, 500, 1000, Double.MaxValue};

            foreach (double number in numbers)
                Console.WriteLine("The base 10 log of " + number + " is " + Math.Log10(number));
            Console.ReadLine();
        }
    }
}
