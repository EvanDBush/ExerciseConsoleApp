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

        public void SetCategory(string categoryResponse)
        {
            CategoryOfExercise = categoryResponse;
        }

        public void SetNameOfExercise(string exerciseNameResponse)
        {
            NameOfExercise = exerciseNameResponse;
        }

        public void SetCountOfExercise(int exerciseCountResponse)
        {
            CountOfExercise = exerciseCountResponse;
        }

        public
        
        public ExerciseEvent(DateTime time)
        {
            TimeOfExercise = time;
        }
    }
}
