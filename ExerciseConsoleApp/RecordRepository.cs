using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace ExerciseConsoleApp
{   
    public class RecordRepository
    {
        private readonly List<ExerciseEvent> _exerciseEvents = new List<ExerciseEvent>();

        private string _fileName;

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
