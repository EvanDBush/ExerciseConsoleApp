﻿using CodeLouisvilleLibrary;
using System;
using System.Collections.Generic;

namespace ExerciseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            string userInput = Console.ReadLine().ToLower();

            while (userInput != "q")
            {
                switch (userInput)
                {
                    case "a":
                        LogExercise();
                        break;
                    case "b":
                        ViewRecordBook();
                        break;
                    case "c":
                        EditExerciseList();
                        break;
                    default:
                        ReturnToMenu();
                        break;

                }

                ReturnToMenu();
                userInput = Console.ReadLine().ToLower();
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*********      Exercise Console App      *********");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Welcome to the Exercise Console App!");
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine(" a - Log an Exercise to RecordBook");
            Console.WriteLine(" b - View Exercise RecordBook");
            Console.WriteLine(" c - Add/Remove/Edit Exercises");
            Console.WriteLine(" q - Exit Program");
        }

        static void ReturnToMenu()
        {
            Console.WriteLine("Press enter to return to the Menu");
            Console.ReadLine();
            Console.Clear();
            DisplayMenu();
        }
        static void LogExercise()
        {
            Console.WriteLine("Let's log in an exercise! Did you work out today?");
            Console.WriteLine("Type y for Yes");
            Console.WriteLine("Type n for No");

            string openingResponse = Console.ReadLine();

            if (openingResponse == "y")
            {
                Console.WriteLine("That is Great! What did you work on?");

                Console.WriteLine("1) Cardio");
                Console.WriteLine("2) Strength");

                string categoryResponse = Console.ReadLine();


                if (categoryResponse == "1")
                {
                    string exerciseCategory = "Cardio";

                    switch (exerciseNameResponse)
                    {
                        case "1":
                            string exerciseName = "Walk";
                            break;
                        case "2":
                            string exerciseName = "Run";
                            break;
                        case "3":
                            string exerciseName = "Swim";
                            break;
                        default:
                            Console.WriteLine("I'm Sorry, that input did not work.");
                            DisplayMenu();
                            break;

                    }

                    Console.WriteLine("1) Walk");
                    Console.WriteLine("2) Run");
                    Console.WriteLine("3) Swim");
                    Console.WriteLine("4) Back to Main Menu");

                    string exerciseNameResponse = Console.ReadLine();


                    Console.ReadLine();
                }

                if (categoryResponse == "2")
                {
                    string exerciseCategory = "Strength";

                    switch (exerciseNameResponse)
                    {
                        case "1":
                            string exerciseName = "Push-ups";
                            break;
                        case "2":
                            string exerciseName = "Sit-ups";
                            break;
                        case "3":
                            string exerciseName = "Lunge";
                            break;
                        case "4":
                            string exerciseName = "Squats";
                            break;
                        default:
                            Console.WriteLine("I'm Sorry, that input did not work.");
                            DisplayMenu();
                            break;

                    }

                    Console.WriteLine("1) Push-ups");
                    Console.WriteLine("2) Sit-ups");
                    Console.WriteLine("3) Lunge");
                    Console.WriteLine("4) Squats");
                    Console.WriteLine("5) Cardio Exercises");

                    string exerciseNameResponse = Console.ReadLine();

                    if (exerciseNameResponse == "1")
                    {

                        Console.WriteLine("how many Push-ups did you do?");
                        int exerciseCountResponse = int.Parse(Console.ReadLine());

                        var exerciseEvent = new ExerciseEvent();
                        exerciseEvent.NameOfExercise = exerciseNameResponse;
                        exerciseEvent.CategoryOfExercise = categoryResponse;
                        exerciseEvent.CountOfExercise = exerciseCountResponse;

                        Console.WriteLine(exerciseEvent);
                        DisplayMenu();

                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
                    ReturnToMenu();
                }

                // use CLLibrary menu instead.
                // Create a dictionary or list, populate it with several values,
                // retrieve at least one value, and use it in your program

            }

            if (openingResponse == "n")
            {

                DateTime currentTime = DateTime.Now;
                int hoursLeft = 23 - currentTime.Hour;
                int minutesNow = currentTime.Minute;

                static string GetMinutes(int hoursLeft)
                {
                    if (minutesNow = 0)
                    {
                        
                        _ = hoursLeft + 1;
                        
                    }
                    else
                    {
                        _ = 60 - currentTime.Minute;
                    }
                }


                Console.WriteLine("Thats ok! It is only " + currentTime.TimeOfDay + " right now. There is still");
                Console.WriteLine(hoursLeft + "hours and " + GetMinutes(hoursLeft) + " minutes left today!");
                Console.WriteLine("Go do an exercise and come back!");
                ReturnToMenu();

                // get current time. calculate how much time is left in a day.
                // Calculate and display data based on an external factor
                // (ex: get the current     b ate, and display how many days remaining until some event)
            }
            else
            {
                //phrasing??
                Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
            }

            Console.ReadLine();
        }

        static void ViewRecordBook()
        {
            switch (RecordViewResponse)
            {
                case "1":
                    string recordSpan = "All-Time Totals";
                    break;
                case "2":
                    string recordSpan = "This Weeks Totals";
                    break;
                case "3":
                    string recordSpan = "Today's Totals";
                    break;
                case "4":
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("I'm Sorry, that input did not work.");
                    DisplayMenu();
                    break;

            }

            Console.WriteLine("Which Records would you like to view?");
            Console.WriteLine(" 1 - All-Time Totals");
            Console.WriteLine(" 2 - This Weeks Totals");
            Console.WriteLine(" 3 - Todays Totals");
            Console.WriteLine(" 4 - Back to Main Menu");

            string RecordViewResponse = Console.ReadLine();

        }
        static void EditExerciseList()
        {
            Console.WriteLine("This feature is under development.");
            ReturnToMenu();

        }


    }

}
