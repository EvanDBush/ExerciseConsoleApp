using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConsoleApp
{
    public class ExerciseEvent
    {
        private string _categoryOfExercise;
        public string CategoryOfExercise
        {
            get 
            { 
                return _categoryOfExercise;
            }
            set
            {
                _categoryOfExercise = value;
            }
        }

        private string _nameOfExercise;

        public string NameOfExercise
        {
            get
            {
                return _nameOfExercise;
            }
            set
            {
                _categoryOfExercise = value;
            }
        }

        private int _countOfExercise;
        public int CountOfExercise
        {
            get
            {
                return _countOfExercise;
            }
            set
            {
                _countofExercise = value;
            }
        }

        private DateTime _timeOfExercise;
        public DateTime TimeOfExercise
        {
            get
            {
                return this._timeOfExercise;
            }
            set
            {
                this._timeOfExercise = value;
            }
        }            
    }

        
       
    }
}
