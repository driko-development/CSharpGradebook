using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int choice = -1;
            string name;
            string options = "0. Exit\n" +
                             "1. Add a new Grade\n" +
                             "2. Calculate average\n" +
                             "3. Calculate lowest grade\n" +
                             "4. Calculate highest grade\n";

            // Prompt the user to enter a name for the gradebook
            Console.Write("Enter book name: ");
            name = Console.ReadLine();

            // Create new book with given name
            var gradeBook = new Book(name);       

            while ( choice != 0 )
            {
                // Display Menu options
                Console.WriteLine(options);

                // Prompt user to enter choice
                Console.Write("Enter choice: ");

                // Then validate that they have entered an integer
                while ( !int.TryParse( Console.ReadLine(), out choice ) )
                    Console.Write("ERROR: Enter a valid choice: ");
                
                // Execute the desired choice
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.");
                        break;
                    case 1:
                        EnterGrade(gradeBook);
                        break;

                    case 2:
                        if (gradeBook.isEmpty()) Console.WriteLine("Add a grade to get started.");
                        
                        else Console.WriteLine($"The average of the grades is: {gradeBook.CalculateAverage():N2}");
                        
                        break;
                    
                    case 3:
                        if (gradeBook.isEmpty()) Console.WriteLine("Add a grade to get started.");
                        
                        else Console.WriteLine($"The average of the grades is: {gradeBook.CalculateLowestGrade():N2}");
                        
                        break;

                    case 4:
                        if (gradeBook.isEmpty()) Console.WriteLine("Add a grade to get started.");
                        
                        else Console.WriteLine($"The average of the grades is: {gradeBook.CalculateHighestGrade():N2}");
                        
                        break;
                    
                    default:
                        Console.WriteLine($"Invalid option: {choice}");
                        break;
                }
            }
            
        }

        private static void EnterGrade(Book gradeBook)
        {
            Console.Write("Enter grade: ");
            double grade;
            while ( !double.TryParse( Console.ReadLine(), out grade ) )
                Console.Write("ERROR: Enter a valid grade: ");
            gradeBook.AddGrade(grade);
        }
    }
}
