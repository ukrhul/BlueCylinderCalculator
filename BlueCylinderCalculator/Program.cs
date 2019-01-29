using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeProgramInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            // your code goes here

            // DECLARATIONS
            string studentName; // variable to store the student's name
            string collegeProgram; // variable to store the program name
            int yearsToCompletion; // variable to store the years to completion
      
            // INPUT

            Console.WriteLine("Please enter your fullname");
            studentName = Console.ReadLine();


            // PROCESSING

            if (studentName == "")
            {

                Console.WriteLine("Please enter valid name");

                // exit the console window
                Console.Write("\nPress any key to exit... ");
                Console.ReadKey();

            }
            else
            {

                // INPUT

                Console.WriteLine("Please enter the program name");
                collegeProgram = Console.ReadLine();

                // PROCESSING

                if (collegeProgram == "")
                {

                    Console.WriteLine("Please enter valid program name");

                    // exit the console window
                    Console.Write("\nPress any key to exit... ");
                    Console.ReadKey();

                }
                else
                {

                    // INPUT

                    Console.WriteLine("Please enter the years of program completion");
                    yearsToCompletion = int.Parse(Console.ReadLine());

                    if (Int32.TryParse(Console.ReadLine(), out yearsToCompletion))
                    {

                        Console.WriteLine("Please enter valid years of program completion");

                        // exit the console window
                        Console.Write("\nPress any key to exit... ");
                        Console.ReadKey();

                    }
                   else
                    {

                        if ((yearsToCompletion >= 1) && (yearsToCompletion <= 3))
                        {

                            Console.WriteLine("Please enter valid years of program completion(1-3)");

                        }
                        else
                        {
                            // OUTPUT
                            // output the values stored in the three program variables
                            Console.WriteLine("Name: " + studentName);
                            Console.WriteLine("Program: " + collegeProgram);
                            Console.WriteLine("Years to completion: " + yearsToCompletion);
                        }
                    }

                   

                    // exit the console window
                    Console.Write("\nPress any key to exit... ");
                    Console.ReadKey();
                }
               
            }
        }
    }
}
