using System;

namespace lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 6, 7, 8 };

            ICalc2 calc = new Array(numbers);

            Console.WriteLine("Distinct values: " + calc.CountDistinct());

            Console.WriteLine("Equal to 4: " + calc.EqualToValue(4));
        }
    }
}