using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz Solution:");
            
            List<int> FizzBuzzList = new List<int>();

            for (var i = 1; i <= 100; i++)
            {
                FizzBuzzList.Add(i);
            }

            foreach ( var num in FizzBuzzList)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine(num + " " + "FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine(num + " " + "Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine(num + " " + "Buzz");
                }
            }
        }
    }
}
