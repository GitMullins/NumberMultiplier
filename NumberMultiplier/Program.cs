using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to multiply or square your numbers?");
            var decision = Console.ReadLine();

            Console.WriteLine("Input numbers; seperate each number using a comma");
            var input = Console.ReadLine();

            string[] stringNumbers = input.Split(",");
            List<int> numbersList = new List<int>();

            foreach (var stringNumber in stringNumbers)
            {
                int numero = int.Parse(stringNumber);
                numbersList.Add(numero);
            }

            if (decision == "multiply")
            {
                int multipliedTotal = numbersList.Aggregate((a, x) => a * x);
                Console.WriteLine(multipliedTotal);
            }

            if (decision == "square")
            {
                int[] numeros = numbersList.ToArray();
                var squaredArray = numeros.Select(x => x * x).ToArray();

                string squaredNum = "";

                foreach (int numero in squaredArray)
                {
                    squaredNum += $"{ numero},";
                    //Console.WriteLine(numero);
                }
                Console.WriteLine(squaredNum);
            }

        }
    }
}
