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
                    case "1":
                        LogExercise();
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                    default:
                        break;

                }

                Console.WriteLine("Press enter to return to the Menu");
                Console.ReadLine();
                Console.Clear();
                DisplayMenu();
                userInput = Console.ReadLine().ToLower();   
            }
    }

    static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Exercise Console App!");
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine(" 1 - Log an Exercise to RecordBook");
            Console.WriteLine(" 2 - View Exercise RecordBook");
            Console.WriteLine(" 3 - Add/Remove/Edit Exercises");
            Console.WriteLine(" q - Exit Program")
        }
    static void LogExercise()
        {
            Console.WriteLine("Hello! Did you work out today?");
            Console.WriteLine("Type 1 for Yes");
            Console.WriteLine("Type 2 for No");

            string openingResponse = Console.ReadLine();

            if (openingResponse == "1")
            {
                Console.WriteLine("That is Great! What did you work on?");

                Console.WriteLine("1) Cardio");
                Console.WriteLine("2) Strength");

                string categoryResponse = Console.ReadLine();

                if (categoryResponse == "1")
                {
                    Console.WriteLine("1) Walk");
                    Console.WriteLine("2) Run");
                    Console.WriteLine("3) Swim");
                    Console.WriteLine("4) Strength Exercises");


                    Console.ReadLine();
                }

                if (categoryResponse == "2")
                {
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

                    }
                }

                else
                {
                    //phrasing??
                    Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
                }

                // use CLLibrary menu instead.
                // Create a dictionary or list, populate it with several values,
                // retrieve at least one value, and use it in your program



                //Implement a “master loop” console application where the user
                //can repeatedly enter commands/perform actions,
                //including choosing to exit the program
            }

            if (openingResponse == "2")
            {

                DateTime currentTime = DateTime.Now;
                int hoursLeft = 23 - currentTime.Hour;
                int minutesLeft = GetMinutes(hoursLeft);

                static void GetMinutes(int hoursLeft)
                {
                    if (currentTime.Minute = 0)
                    {
                        minutesLeft = 0;
                        _ = hoursLeft + 1;
                    }
                    else
                    {
                        minutesLeft = 60 - currentTime.Minute;
                    }
                }


                Console.WriteLine("Thats ok! It is only " + currentTime.TimeOfDay + " right now. There is still");
                Console.WriteLine(hoursLeft + "hours and " + minutesLeft + " minutes left today!");
                Console.WriteLine("Go do an exercise and come back!");

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
    


        private static void getMinutes(int v, int hoursLeft)
        {
            throw new NotImplementedException();
        }
    }



}
