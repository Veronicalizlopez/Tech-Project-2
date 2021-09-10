// Author: Veronica Lopez
//Date: 09/10/21
// Project 2: Creating conditional statements
using System;

namespace Tech_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // state the string and variables 
            string gradeLetter;

            string gradeNumberStr;

            decimal gradeNumber;
           
          

            // ask for input
            Console.WriteLine("Please enter your Grade Number in ISM 4300");
            // Add a catch block to check users input


            // Gather user input 
            gradeNumberStr = Console.ReadLine();
            gradeNumber = decimal.Parse(gradeNumberStr);
            //if the user inputs a number higher than 89 the grade letter will display as an A
            if (gradeNumber > 89)
            {
                gradeLetter = "A";
                Console.WriteLine("Your Letter Grade is A");
            }
            //if the grade is higher than 80 but lower than 89 it will display as B 
            else if (gradeNumber <= 89 && gradeNumber >= 80)
            {
                gradeLetter = "B";
                Console.WriteLine("Your Letter Grade is B");
            }
            //if number enetered is lower that 79 but higher than 70 it will be displayed as C
            else if (gradeNumber <= 79 && gradeNumber >= 70)
            {
                gradeLetter = "C";
                Console.WriteLine("Your Letter Grade is C");

            }
            //if number is inbetween 69 to 60 the letter grade is D
            else if (gradeNumber <= 69 && gradeNumber >= 60)
            {
                gradeLetter = "D";
                Console.WriteLine("Your Letter Grade is D");
            }
            //Anything lowwer than 60 is F
                    if (gradeNumber < 60)
                    {
                        gradeLetter = "F";
                        Console.WriteLine("Your Letter Grade is F");
                    }
                    else
                    {
                        gradeLetter = "Grade" + gradeNumber;
                        Console.WriteLine("Grade:" + gradeLetter);
                    }
                
                 















        }
    }
}
