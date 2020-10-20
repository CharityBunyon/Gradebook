using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var p = new Program();
            Program.Main(args); //infinite loop
            */

            var book = new Book("Happy Times");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.GetStatistics();

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}.");
            Console.WriteLine($"The highest grade is {stats.High}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            //var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            //grades.Add(56.1);

        }
    }
}

