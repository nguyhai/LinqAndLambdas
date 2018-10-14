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
            // LINQ Queries on Objects
            List<Person> people = new List<Person>()
            {
                new Person("Hai", 120, 70, Gender.Male),
                new Person("Fey", 110, 60, Gender.Female),
                new Person("Kira", 130, 30, Gender.Female),
                new Person("Luna", 140, 90, Gender.Female),
                new Person("Anna", 150, 100, Gender.Female),
                new Person("Kyle", 160, 120, Gender.Male),
                new Person("John", 170, 77, Gender.Male)
            };











            //----------------------------------------------------------------------------------------------------------------------------------------//
            //string sentence = "I Love cats";
            //string[] catNames = { "Lucky", "Bella", "Luna", "Orea", "Simba", "Toby", "Loki", "Oscar"};
            //int[] numbers = { 1, 2, 5, 3, 5, 2, 5, 7, 87, 2, 3, 4, 35, 6, 1, 1, 7, 5, 2, 4, 54 };

            //// Here we are simple creating the getTheNumbers query. It is NOT executed until it is called in the WriteLine below

            //// You can also split up the conditions to make it more readable, and also order them by ascending or descending:
            //var getTheNumbers = from number in numbers
            //                    where (number > 5)
            //                    where (number < 10)
            //                    orderby number descending
            //                    select number;

            //var getCatNames = from catName in catNames
            //                  where catName.Length == 4
            //                  select catName;

            //var catsWithA = from cat in catNames
            //                where cat.Contains("a") && (cat.Length < 5)
            //                select cat;

            //// Making a list of numbers, and adding from numbers array if the number is less than 5
            //List<int> newNumbers = new List<int>();

            //foreach (var number in numbers)
            //{
            //    if (number < 5)
            //    {
            //        newNumbers.Add(number);
            //    }
            //}

            //// Printing both to see what they do. The loop does the same thing, but it is much easier to just use a LINQ query for the same result. 
            //Console.WriteLine(string.Join(", ", getTheNumbers));
            //Console.WriteLine(string.Join(", ", newNumbers));
            //Console.WriteLine(string.Join(", ", getCatNames));
            //Console.WriteLine(string.Join(", ", catsWithA));

        }
    }
}
