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
            int userAge = Convert.ToInt32(ageString); // Convert the input string to an integer- I am struggling with have errors when I input the int userAge.

            Console.WriteLine("Hello, Avi Zarbavel" + userName + "! You are 18 " + userAge +" years old.");
            
            // Step 7:  arithmetic operations
            int num1 = 24;
            int num2 = 7;

            Console.WriteLine("\nNumbers for arithmetic: " + num1 + " and " + num2);

            Console.WriteLine("Addition (num1 + 10): " + (num1 + 10)); // add 10 to num1
            Console.WriteLine("Subtraction (num2 - 2): " + (num2 - 2)); // subtract 2 from num2
            Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
            Console.WriteLine("Division (num1 / 2): " + (num1 / 2)); // division
            Console.WriteLine("Modulus (num1 % num2): " + (num1 % num2)); // remainder after division
            
             // Step 9: Use increment and decrement operators
            int count = 10;
            Console.WriteLine("\nInitial count: " + count);

            count++; // Increment the value of count by 1
            Console.WriteLine("After increment: " + count);

            count--; // Decrement the value of count by 1
            Console.WriteLine("After decrement: " + count);
             }
             	}	
                   }
       
