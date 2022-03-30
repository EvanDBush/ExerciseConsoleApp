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
                    case "q":
                        ExitProgram();
                        break;
                    default:
                        ReturnToMenu();
                        break;

                }
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
                    string exerciseName = "";

                    Console.WriteLine("1) Walk");
                    Console.WriteLine("2) Run");
                    Console.WriteLine("3) Swim");
                    Console.WriteLine("4) Back to Main Menu");

                    string exerciseNameResponse = Console.ReadLine();

                    switch (exerciseNameResponse)
                    {
                        case "1":
                            exerciseName = "Walk";
                            break;
                        case "2":
                            exerciseName = "Run";
                            break;
                        case "3":
                            exerciseName = "Swim";
                            break;
                        default:
                            Console.WriteLine("I'm Sorry, that input did not work.");
                            DisplayMenu();
                            break;

                    }

                    Console.WriteLine($"how long did you {exerciseName} for?");
                    Console.WriteLine("please enter your estimate in full minutes");
                    int exerciseCount = int.Parse(Console.ReadLine());

                    var exerciseEvent = new ExerciseEvent();
                    exerciseEvent.NameOfExercise = exerciseName;
                    exerciseEvent.CategoryOfExercise = exerciseCategory;
                    exerciseEvent.CountOfExercise = exerciseCount;

                    var recordRepository = new RecordRepository();
                    recordRepository.Add(exerciseEvent);

                    Console.WriteLine(exerciseEvent);
                    ReturnToMenu();


                    Console.ReadLine();
                }

                if (categoryResponse == "2")
                {
                    string exerciseCategory = "Strength";
                    string exerciseName = "";

                    Console.WriteLine("1) Push-ups");
                    Console.WriteLine("2) Sit-ups");
                    Console.WriteLine("3) Lunge");
                    Console.WriteLine("4) Squats");
                    Console.WriteLine("5) Cardio Exercises");

                    string exerciseNameResponse = Console.ReadLine();

                    switch (exerciseNameResponse)
                    {
                        case "1":
                            exerciseName = "Push-ups";
                            break;
                        case "2":
                            exerciseName = "Sit-ups";
                            break;
                        case "3":
                            exerciseName = "Lunges";
                            break;
                        case "4":
                            exerciseName = "Squats";
                            break;
                        default:
                            Console.WriteLine("I'm Sorry, that input did not work.");
                            ReturnToMenu();
                            break;

                    }

                        Console.WriteLine($"how many {exerciseName} did you do?");
                        int exerciseCount = int.Parse(Console.ReadLine());

                        var exerciseEvent = new ExerciseEvent();
                        exerciseEvent.NameOfExercise = exerciseName;
                        exerciseEvent.CategoryOfExercise = exerciseCategory;
                        exerciseEvent.CountOfExercise = exerciseCount;

                        Console.WriteLine(exerciseEvent);
                        ReturnToMenu();

                    
                }
                else
                {
                    Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
                    ReturnToMenu();
                }

            }

            if (openingResponse == "n")
            {

                DateTime currentTime = DateTime.Now;
                DateTime midnightTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day + 1, 0, 0, 0);
                TimeSpan timeToMidnight = midnightTime - currentTime;
                
                Console.WriteLine("Thats ok! It is only " + currentTime.TimeOfDay + " right now. There is still");
                Console.WriteLine(timeToMidnight.Hours + "hours and " + timeToMidnight.Minutes + " minutes left today!");
                Console.WriteLine("Go do an exercise and come back!");
                ReturnToMenu();

            }
            else
            {
                Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
            }
        }

        static int MinutesLeft(ref int hoursLeft, int minutesNow)
        {
            int minutesLeft = 60 - minutesNow;

            if (minutesLeft == 60)
            {

                hoursLeft--;
                return minutesLeft;

            }
            else
            {
                
                return minutesLeft;
            }
        }
        static void ViewRecordBook()
        {
            string recordSpan = "";

            Console.WriteLine("Which Records would you like to view?");
            Console.WriteLine(" 1 - All-Time Totals");
            Console.WriteLine(" 2 - This Weeks Totals");
            Console.WriteLine(" 3 - Todays Totals");
            Console.WriteLine(" 4 - Back to Main Menu");

            string RecordViewResponse = Console.ReadLine();
            string RecordSpan = "";

            switch (RecordViewResponse)
            {
                case "1":
                    recordSpan = "All-Time Totals";
                    break;
                case "2":
                    recordSpan = "This Weeks Totals";
                    break;
                case "3":
                    recordSpan = "Today's Totals";
                    break;
                case "4":
                    ReturnToMenu();
                    break;
                default:
                    Console.WriteLine("I'm Sorry, that input did not work.");
                    ReturnToMenu();
                    break;

            }

        }
        static void EditExerciseList()
        {
            Console.WriteLine("This feature is under development.");
            ReturnToMenu();

        }

        static void ExitProgram()
        {
            Console.WriteLine("Are you sure you want to exit  the program?");
            Console.WriteLine("Type y for Yes. I want to Exit");
            Console.WriteLine("Type n for No. I want to return to the menu.");

            string ExitProgramResponse = Console.ReadLine().ToLower();

            if (ExitProgramResponse != "y")
            {
                ReturnToMenu();
            }
            else
            {
                Console.WriteLine("Later!");
            }
        }


    }

}
