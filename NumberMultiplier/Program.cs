using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] stringNumbers = input.Split(",");
            List<int> numbersList = new List<int>();

            foreach (var stringNumber in stringNumbers)
            {
                int numero = int.Parse(stringNumber);
                numbersList.Add(numero);
            }

            int r = numbersList.Aggregate((a, x) => a * x);

            Console.WriteLine(r);
        }
    }
}
