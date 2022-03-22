namespace ExerciseConsoleApp
{
    public class Exercise 
    {
        public string Type;
        public string Name;
        public int Count;
        public DateTime Time;

    }
    class Program 
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Hello! Did you work out today?");
            Console.WriteLine("Type 1 for Yes");
            Console.WriteLine("Type 2 for No");

            string userOpeningResponse = Console.ReadLine();

            if (userOpeningResponse == "1")
            {
                Console.WriteLine("That is Great! What did you work on?");

                Console.WriteLine("1) Cardio");
                Console.WriteLine("2) Strength");
                
            string userCategoryResponse = Console.ReadLine();

                if (userCategoryResponse == "1")
                {
                    Console.WriteLine("1) Walk");
                    Console.WriteLine("2) Run");
                    Console.WriteLine("3) Swim");
                    

                    Console.ReadLine();
                }

                if (userOpeningResponse == "2")
                {
                    Console.WriteLine("1) Push-ups");
                    Console.WriteLine("2) Sit-ups");
                    Console.WriteLine("3) Lunge");
                    Console.WriteLine("4) Squats");

                    Console.ReadLine();
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

            if (userOpeningResponse == "2")
            {
                DateTime currentTime = DateTime.Now;
                
                Console.WriteLine(currentTime);
                // DateTime hoursLeft = 24:00 - currentTime.Hour;
                // minutesLeft ???

                //Console.WriteLine("Thats ok! It is only" + currentTime "right now. There is still");
                //Console.WriteLine(hoursLeft + "hours and" minutesLeft "minutes left today!");
                
                // get current time. calculate how much time is left in a day.
                // Calculate and display data based on an external factor
                // (ex: get the current date, and display how many days remaining until some event)
            }
            else
            {
                //phrasing??
                Console.WriteLine("I'm sorry,that input did not work. Please try entering 1 or 2 again.");
            }

            Console.ReadLine();
        }
    }



}
