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
            string[] catNames = { "Lucky", "Bella", "Luna", "Orea", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 1, 2, 5, 3, 5, 2, 5, 7, 87, 2, 3, 4, 35, 6, 1, 1, 7, 5, 2, 4, 54 };

            // Lets say we want to extract all odd numbers from numbers list, and add it to a new collection. With 1 line of code, we can do that using lambda expressions.
            List<int> oddNumbers = numbers.Where(n => (n % 2 == 1)).ToList();

            Console.WriteLine(string.Join(", ", oddNumbers));


            double average = catNames.Average(cat => cat.Length); // Finding the average length of the cat name, of cat in catNames
            Console.WriteLine(average);

            double minCatNameLength = catNames.Min(cat => cat.Length);
            Console.WriteLine(minCatNameLength);

            double maxCatNameLength = catNames.Max(cat => cat.Length);
            Console.WriteLine(maxCatNameLength);

            double sumCatNameLength = catNames.Sum(cat => cat.Length);
            Console.WriteLine(sumCatNameLength);




            // ----------------------------------------------------------------------------------------------------
            // LINQ Queries on Objects
            //List<Person> people = new List<Person>()
            //{
            //    new Person("Hai", 120, 70, Gender.Male),
            //    new Person("Fey", 110, 60, Gender.Female),
            //    new Person("Kira", 130, 30, Gender.Female),
            //    new Person("Luna", 140, 90, Gender.Female),
            //    new Person("Anna", 150, 100, Gender.Female),
            //    new Person("Kyle", 160, 120, Gender.Male),
            //    new Person("John", 170, 77, Gender.Male)
            //};

            //// Lets say we want people who's name is 4 characters long, and we want them in a new collection

            //var fourCharPeople = from p in people
            //                     where (p.Name.Length == 4)
            //                     orderby p.Name, p.Height
            //                     select p;

            ////Console.WriteLine(string.Join(", ", fourCharPeople));

            //foreach (var item in fourCharPeople)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Weight: {item.Weight}");
            //}

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
