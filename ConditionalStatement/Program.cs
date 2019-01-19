/*
 Author: Peter Millet
 Date: 01/18/2019
 Comments: A program to show conditional statements
*/
 
using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                string userinput = Console.ReadLine();

                int grade = int.Parse(userinput);
                
                // This code checks what the user has typed and converts it into an int if appropriate.

                if (grade < 60)
                {
                    Console.WriteLine("Grade: F");
                    Console.ReadKey(true);
                }

                else if ((grade >= 60) && (grade <= 61))
                {

                    Console.WriteLine("Grade: D-");
                    Console.ReadKey(true);
                }

                else if ((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("Grade: D");
                    Console.ReadKey(true);
                }

                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("Grade: D+");
                    Console.ReadKey(true);
                }

                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Grade: C-");
                    Console.ReadKey(true);
                }

                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Grade: C");
                    Console.ReadKey(true);
                }

                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Grade: C+");
                    Console.ReadKey(true);
                }

                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Grade: B-");
                    Console.ReadKey(true);
                }

                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Grade: B");
                    Console.ReadKey(true);
                }

                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Grade: B+");
                    Console.ReadKey(true);
                }

                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.Write("Grade: A-");
                    Console.ReadKey(true);
                }

                else if ((grade >= 92) && (grade <= 98))
                {
                    Console.WriteLine("Grade: A");
                    Console.ReadKey(true);
                }

                else if ((grade >= 99) && (grade <= 100))
                {
                    Console.WriteLine("Grade: A+");
                    Console.ReadKey(true);
                }
                // All this code checks what number has been entered and assigns the corresponding letter grade.
                
                else
                {
                    Console.WriteLine("Enter a number that is in the grading scale, the program will now close");
                    Console.ReadKey(true);
                }
                // This message appears when a number that is not in the grading scale is entered.
            }
            catch
            {
                Console.WriteLine("Please enter a number, the program will no close");
                Console.ReadKey(true);
            }
            // This message appears when something besides a number is entered.
        }
    }
}
