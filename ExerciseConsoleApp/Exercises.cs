using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConsoleApp
{
    public class ExerciseEvent
    {
        public string CategoryOfExercise;
        public string NameOfExercise;
        public int CountOfExercise;
        public DateTime TimeOfExercise;

        public void SetCategory(string userCategoryResponse)
        {
            CategoryOfExercise = userCategoryResponse;
        }

        public ExerciseEvent(string userExerciseNameResponse)
        {
            NameOfExercise = userExerciseNameResponse;
        }

        public Exe
        
        public ExerciseEvent(DateTime time)
        {
            TimeOfExercise = time;
        }
    }
}
