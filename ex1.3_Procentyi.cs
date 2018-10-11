using System;
using System.Globalization;

namespace ex1_3
{
    class Program
    {
        public static double Calculate(string userInput)
        {
            var userPrint = userInput.Split(' ');
            var sum = Double.Parse(userPrint[0], CultureInfo.InvariantCulture);
            var mounth = Double.Parse(userPrint[1], CultureInfo.InvariantCulture);
            var percent = 0.01 * Double.Parse(userPrint[2], CultureInfo.InvariantCulture);
            sum =  sum*Math.Pow(1+percent/12, mounth);
            return sum; 

        }
        static void Main()
        {
            Console.WriteLine(Calculate(Console.ReadLine()));
            Console.ReadKey();
        }

    }
}
