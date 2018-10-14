using System;
using System.Collections.Generic;
using System.Linq; // Need to have this namespace if you want to use LINQ
using System.Text;
using System.Threading.Tasks;

// Practice program to learn more about LINQ and Lambdas

namespace LinqAndLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I Love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Orea", "Simba", "Toby", "Loki", "Oscar"};
            int[] numbers = { 1, 2, 5, 3, 5, 2, 5, 7, 87, 2, 3, 4, 35, 6, 1, 1, 7, 5, 2, 4, 54 };

            var getTheNumbers = from number in numbers
                                where number < 5
                                select number;

            // Making a list of numbers, and adding from numbers array if the number is less than 5
            List<int> newNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number < 5)
                {
                    newNumbers.Add(number);
                }
            }

            // Printing both to see what they do. The loop does the same thing, but it is much easier to just use a LINQ query for the same result. 
            Console.WriteLine(string.Join(", ", getTheNumbers));
            Console.WriteLine(string.Join(", ", newNumbers));








        }
    }
}
