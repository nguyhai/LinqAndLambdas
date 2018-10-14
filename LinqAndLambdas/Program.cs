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
                                select number; // No where clause, so we are selecting all numbers. 

            Console.WriteLine(string.Join(", ", getTheNumbers));


        }
    }
}
