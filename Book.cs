using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;

        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value.");
            }
        }


        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue; //starting off with the lowest value
            result.Low = double.MaxValue;


            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }
    }

}