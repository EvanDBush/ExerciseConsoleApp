# Exercise Console Application

## Introduction:

This simple C# application logs and saves counts for exercises. 
It can count totals by workout category or specific type of exercise.
It prompts the user to log exercise data or review records of exercises. 
If the user has nothing to log, it responds with encouragement and a countdown for time left in the day to still work out.

***

## Instructions:

This app was built using Microsoft Visual Studio Code 2022 and .NET 6.0. For best results, please run with these tools.

## Project Requirements:

[?] Project is uploaded to your GitHub repository and shows at minimum 5 separate commits.

[?] Project includes a README file.

[?] Create at least one class, then create at least one object of that class and populate it with data. Use or display the data in your application.

[?] Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application.

***

## Three (or more) C# Features:

1) Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.
	- creates a do/while loop in main of Program.cs as long as ExitProgram() is true.

	```
	static void Main(string[] args)
        {
            do
            {
                DisplayMenu();
            }
            while (ExitProgram());     
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

	```

2) Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.
    - creates List of EventExercises objects in RecordRepository.cs. Uses it to count exercise totals.

    ```
    private readonly List<ExerciseEvent> _exerciseEvents = new List<ExerciseEvent>();

    public List<ExerciseEvent> FindEventsByCategory(string category)
        {
            List<ExerciseEvent> categoryList = new List<ExerciseEvent>();
            foreach (ExerciseEvent exerciseEvent in _exerciseEvents)
            {
                if (exerciseEvent.CategoryOfExercise == category)
                {
                    categoryList.Add(exerciseEvent);
                }
            }
            return categoryList;
        }

    ```
3) Read data from an external file, such as text, JSON, CSV, etc and use that data in your application.
    - creates json file to store exercise events between uses.

    ```
    public RecordRepository(string fileName)
        {
            _fileName = fileName;
            if(File.Exists(_fileName))
            {
                string json = File.ReadAllText(_fileName);
                _exerciseEvents = JsonSerializer.Deserialize<List<ExerciseEvent>>(json)
                    ?? new List<ExerciseEvent>();
            }
        }
        public void Add(ExerciseEvent exercise)
        {
            _exerciseEvents.Add(exercise);
            string json = JsonSerializer.Serialize<List<ExerciseEvent>>(_exerciseEvents);
            File.WriteAllText(_fileName, json);
        }

    ```
4) Use a LINQ query to retrieve information from a data structure (such as a list or array) or file.
    - creates a corresponding LINQ query for each record being calculated.

```
public List<ExerciseEvent> FindEventsByCategory(string category)
        {
            List<ExerciseEvent> categoryList = new List<ExerciseEvent>();
            foreach (ExerciseEvent exerciseEvent in _exerciseEvents)
            {
                if (exerciseEvent.CategoryOfExercise == category)
                {
                    categoryList.Add(exerciseEvent);
                }
            }
            return categoryList;
        }

        public int GetTotalCountByCategoryName(string category)
        {
            return _exerciseEvents
                .Where(exerciseEvent => exerciseEvent.CategoryOfExercise == category)
                .Select(exerciseEvent => exerciseEvent.CountOfExercise)
                .Sum();
        }


        public int GetTotalCountByExerciseName(string exerciseName)
        {
            return _exerciseEvents
                .Where(exerciseEvent => exerciseEvent.NameOfExercise == exerciseName)
                .Select(exerciseEvent => exerciseEvent.CountOfExercise)
                .Sum();
        }

        public int GetPersonalBestByExerciseName(string exerciseName)
        {
            return _exerciseEvents
                .Where(exerciseEvent => exerciseEvent.NameOfExercise == exerciseName)
                .Select(exerciseEvent => exerciseEvent.CountOfExercise)
                .Max();
        }

```

5) Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event)
    - gets current time and creates a DateTime for midnight. The subtracts current time from midnight to get a timespan. this is then displayed in console.

```
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

```

***
***

## Thank You for checking out my C# Console Application!

