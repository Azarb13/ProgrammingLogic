using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Name: Avi Zarbavel
            Title: IT-1050 - Lab 1
            */

            // Step 1
            Console.WriteLine("My Name: Avi Zarbavel");
            Console.WriteLine("Course Title: IT-1050 - Programming Logic");
       		
           	// Step 2
            int favoriteNumber = 3; // My favorite number since childhood
            Console.WriteLine("My favorite number is: " + favoriteNumber);
                
            string favoriteLanguage = "C#"; // Do not have tons of expirience but I enjoyed Python and am starting to see an apeal to C#.
            Console.WriteLine("My favorite programming language is: " + favoriteLanguage);

			double programsWritten = 4.5; // Number of programs I've written (Even though they where beginner level for another IT Course.
            Console.WriteLine("Number of programs I've written before this: " + programsWritten);
            
             bool hasProgrammingExperience = true; // true I got epirience from a course previous to this one
            Console.WriteLine("Do I have programming experience? " + hasProgrammingExperience);

            // Step 4:constant variable
            const string schoolName = "The Ohio State University"; // Your school name
            Console.WriteLine("What School I go to?: " + schoolName);
            
            // Step 5 data type conversions
            double decimalValue = 9.28;
            int intFromDouble = (int)decimalValue; // Explicit casting from double to int
            Console.WriteLine("Original double: " + decimalValue);
            Console.WriteLine("Double to int (explicit cast): " + intFromDouble);
            
             int numberToConvert = 72; // converting integer
            string stringFromInt = Convert.ToString(numberToConvert); // Convert int to string
            Console.WriteLine("Integer converted to a string: " + stringFromInt);

             // Step 6: Getting input from user
            Console.Write("Please enter your name: Avi Zarbavel ");
            string userName = Console.ReadLine();

            Console.Write("Please enter your age: 18 ");
            string ageString = Console.ReadLine();
            int userAge = Convert.ToInt32(ageString); // Convert the input string to an integer- I am strugiling with have errors when I input the int userAge.

            Console.WriteLine("Hello, Avi Zarbavel" + userName + "! You are" + userAge +" years old.");
             }
             	}	
                   }
