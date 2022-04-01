using System;
using System.Collections.Generic;

namespace ExerciseConsoleApp
{
    class Program
    {
        private static RecordRepository recordRepository = new RecordRepository("ExerciseHistory.json");
        static void Main(string[] args)
        {
            do
            {
                DisplayMenu();
            }
            while (ExitProgram());     
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
            Console.WriteLine(" q - Exit Program");

            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "a":
                    LogExercise();
                    break;
                case "b":
                    ViewRecordBook();
                    break;
                case "q":
                    break;
                default:
                    Console.WriteLine("That input was not understood. Please try again.");
                    break;
            }
        
            Console.Clear();
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

                    Console.WriteLine("What Cardio exercise did you do?");
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
                            break;
                    }

                    Console.WriteLine($"how long did you {exerciseName} for?");
                    Console.WriteLine("please enter your estimate in full minutes");
                    int exerciseCount = int.Parse(Console.ReadLine());

                    var exerciseEvent = new ExerciseEvent();
                    exerciseEvent.NameOfExercise = exerciseName;
                    exerciseEvent.CategoryOfExercise = exerciseCategory;
                    exerciseEvent.CountOfExercise = exerciseCount;

                    recordRepository.Add(exerciseEvent);

                    Console.WriteLine(exerciseEvent);
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                if (categoryResponse == "2")
                {
                    string exerciseCategory = "Strength";
                    string exerciseName = "";

                    Console.WriteLine("What Strength exercise did you do?");
                    Console.WriteLine("1) Push-ups");
                    Console.WriteLine("2) Sit-ups");
                    Console.WriteLine("3) Lunges");
                    Console.WriteLine("4) Squats");

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
                            break;
                    }

                    Console.WriteLine($"how many {exerciseName} did you do?");
                    
                    int exerciseCount = int.Parse(Console.ReadLine());
                    var exerciseEvent = new ExerciseEvent();
                    
                    exerciseEvent.NameOfExercise = exerciseName;
                    exerciseEvent.CategoryOfExercise = exerciseCategory;
                    exerciseEvent.CountOfExercise = exerciseCount;
                
                    recordRepository.Add(exerciseEvent);

                    Console.WriteLine(exerciseEvent);
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
                }
            }

            if (openingResponse == "n")
            {

                DateTime currentTime = DateTime.Now;
                DateTime midnightTime = DateTime.Now.AddDays(1).Date;
                TimeSpan timeToMidnight = midnightTime.Subtract(currentTime);
                
                Console.WriteLine("Thats ok! It is only " + currentTime.TimeOfDay + " right now. There is still");
                Console.WriteLine( timeToMidnight.Hours + " hours and " + timeToMidnight.Minutes + " minutes left today!");
                Console.WriteLine("Go do an exercise and come back!");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
            }
        }      
        static void ViewRecordBook()
        {
            Console.WriteLine("Which Records would you like to view?");
            Console.WriteLine(" 1 - All-Exercise Records");
            Console.WriteLine(" 2 - Category Totals");
            Console.WriteLine(" 3 - Exercise Totals");
            Console.WriteLine(" 4 - Personal Bests");
            Console.WriteLine(" 5 - Back to Main Menu");

            string RecordViewResponse = Console.ReadLine();

            switch (RecordViewResponse)
            {
                case "1":
                    GetAllRecords();
                    break;
                case "2":
                    GetCategoryTotals();
                    break;
                case "3":
                    GetExerciseTotals();
                    break;
                case "4":
                    GetPersonalBests();
                    break;
                default:
                    Console.WriteLine("I'm Sorry, that input did not work.");                
                    break;
            }
        }
        static void GetAllRecords() 
        {
            int CardioResult = recordRepository.GetTotalCountByCategoryName("Cardio");
            Console.WriteLine($"Total Cardio Times: {CardioResult} minutes");
            int WalkResult = recordRepository.GetTotalCountByExerciseName("Walk");
            Console.WriteLine($"Walking: {WalkResult} minutes");
            int RunResult = recordRepository.GetTotalCountByExerciseName("Run");
            Console.WriteLine($"Running: {RunResult} minutes");
            int SwimResult = recordRepository.GetTotalCountByExerciseName("Swim");
            Console.WriteLine($"Swimming: {SwimResult} minutes");
            Console.WriteLine();
            int StrengthResult = recordRepository.GetTotalCountByCategoryName("Strength");
            Console.WriteLine($"Total Strength Repetitions: {StrengthResult} repetitions.");
            int PushupResult = recordRepository.GetTotalCountByExerciseName("Push-ups");
            Console.WriteLine($"Push-ups: {PushupResult}");
            int SitupResult = recordRepository.GetTotalCountByExerciseName("Sit-ups");
            Console.WriteLine($"Sit-ups: {SitupResult}");
            int LungesResult = recordRepository.GetTotalCountByExerciseName("Lunges");
            Console.WriteLine($"Lunges: {LungesResult}");
            int SquatsResult = recordRepository.GetTotalCountByExerciseName("Squats");
            Console.WriteLine($"Squats: {SquatsResult}");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        static void GetCategoryTotals()
        {
            Console.WriteLine("What Category would you like to see Totals for?");
            Console.WriteLine("1) Cardio ");
            Console.WriteLine("2) Strength ");

            string CategoryRecordResponse = Console.ReadLine();
            if (CategoryRecordResponse == "1")
            {
                string category = "Cardio";
                int result = recordRepository.GetTotalCountByCategoryName(category);
                Console.WriteLine($"You have done a total of {result} minutes of cardio exercises.");
            }
            if (CategoryRecordResponse == "2")
            {
                string category = "Strength";
                int result = recordRepository.GetTotalCountByCategoryName(category);
                Console.WriteLine($"You have done a total of {result} repetitions of strength exercises.");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
 
            }
        }

        static void GetExerciseTotals()
        {
            string exerciseName = "";

            Console.WriteLine("What exercise would you like to see totals for");
            Console.WriteLine("1) Walking");
            Console.WriteLine("2) Running");
            Console.WriteLine("3) Swimming");
            Console.WriteLine("4) Push-ups");
            Console.WriteLine("5) Sit-ups");
            Console.WriteLine("6) Lunges");
            Console.WriteLine("7) Squats");

            string exerciseTotalsNameResponse = Console.ReadLine();
            
            switch (exerciseTotalsNameResponse)
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
                case "4":
                    exerciseName = "Push-ups";
                    break;
                case "5":
                    exerciseName = "Sit-ups";
                    break;
                case "6":
                    exerciseName = "Lunges";
                    break;
                case "7":
                    exerciseName = "Squats";
                    break;
                default:
                    Console.WriteLine("I'm Sorry, that input did not work.");
                    break;
            }

            int result = recordRepository.GetTotalCountByExerciseName(exerciseName);
            Console.WriteLine($"Your {exerciseName} total is: {result}.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void GetPersonalBests()
        {
            string exerciseName = "";

            Console.WriteLine("What exercise would you like to see personal bests for?");
            Console.WriteLine("1) Walking");
            Console.WriteLine("2) Running");
            Console.WriteLine("3) Swimming");
            Console.WriteLine("4) Push-ups");
            Console.WriteLine("5) Sit-ups");
            Console.WriteLine("6) Lunges");
            Console.WriteLine("7) Squats");
            
            string personalBestNameResponse = Console.ReadLine();

            switch (personalBestNameResponse)
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
                case "4":
                    exerciseName = "Push-ups";
                    break;
                case "5":
                    exerciseName = "Sit-ups";
                    break;
                case "6":
                    exerciseName = "Lunges";
                    break;
                case "7":
                    exerciseName = "Squats";
                    break;
                default:
                    Console.WriteLine("I'm Sorry, that input did not work.");
                    break;
            }

            int result = recordRepository.GetPersonalBestByExerciseName(exerciseName);
            Console.WriteLine($"Your {exerciseName} personal best is: {result}.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

        }
        static bool ExitProgram()
        {
            Console.WriteLine("Do you want to exit  the program?");
            Console.WriteLine("Type y for Yes. I want to Exit");
            Console.WriteLine("Type n for No. I want to return to the menu.");

            string ExitProgramResponse = Console.ReadLine().ToLower();

            if (ExitProgramResponse != "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Later!");
                return false;            
            }
        }


    }

}
