using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConsoleApp
{   
    public class RecordRepository
    {
        private readonly List<ExerciseEvent> _exerciseEvents = new List<ExerciseEvent>();
        public void Add(ExerciseEvent exercise)

        {
            _exerciseEvents.Add(exercise);
        }

        public void SaveToLocal()
        {
            foreach (var exercise in _exerciseEvents)
            {
                Console.WriteLine(exercise);
            }
        }


    }
    
}
