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
                _nameOfExercise = value;
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
                _countOfExercise = value;
            }
        }

        private DateTime _logTime;
        public DateTime LogTime
        {
            get
            {
                DateTime logTime = DateTime.Now;
                return _logTime;
            }
            set
            {
                _logTime = value;
            }
        }

        public override string ToString()
        {
            return $" CategoryofExercise: {CategoryOfExercise}, Exercise Name: {NameOfExercise}, CountofExercise: {CountOfExercise}, LogTime: {LogTime}";
        }
            
        
    }
}