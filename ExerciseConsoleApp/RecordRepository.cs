using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace ExerciseConsoleApp
{   
    public class recordRepository
    {
        private readonly List<ExerciseEvent> _exerciseEvents = new List<ExerciseEvent>();

        private string _fileName;

        public recordRepository(string fileName)
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

    }
    
}
