﻿using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //string name = "Nilouuuuuu";
            //int age = 31;
            // Start here //
            //Console.WriteLine(name+ " is "+age);
            //Console.WriteLine("{0} is {1}", name, age);

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nilou";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Make sure its a number
                if(!int.TryParse(input, out guess))
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its the wrong number
                    Console.WriteLine("Please enter an integer!");

                    // Reset text color
                    Console.ResetColor();

                    // Keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                { 
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its the wrong number
                    Console.WriteLine("Wrong number, try again please!");

                    // Reset text color
                    Console.ResetColor();

                }
            }

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user its the right number
            Console.WriteLine("Bravo, you are correct!");

            // Reset text color
            Console.ResetColor();
        }
    }
}
