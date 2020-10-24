using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Happy Times");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += null;


            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quite.");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

           
            

            var stats = book.GetStatistics();

            Console.WriteLine(Book.category);
            Console.WriteLine($"For the book named {book.Name}.");
            Console.WriteLine($"The lowest grade is {stats.Low}.");
            Console.WriteLine($"The highest grade is {stats.High}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The average grade is {stats.Letter}");
            
        }

        static void OnGradeAdded (object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}

