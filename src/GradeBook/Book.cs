using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if ( grade >= 0 && grade <= 100 ) grades.Add(grade);

            else Console.WriteLine($"{grade} is not a valid grade. No Update made");
        }

        public double CalculateAverage()
        {
            var result = 0.0;

            foreach( var num in grades )
                result += num;
            
            return result / grades.Count;
        }

        public double CalculateHighestGrade()
        {
            var result = double.MinValue;

            foreach( var num in grades )
                if ( num > result ) result = num;

            return result;
        }

        public double CalculateLowestGrade()
        {
            var result = double.MaxValue;

            foreach( var num in grades )
                if ( num < result ) result = num;
                
            return result;
        }

        public bool isEmpty()
        {
            return grades.Count == 0;
        }
    }
}