using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Exercise
    {
        private static List<Exercise> _allExercises = new List<Exercise>();
        public List<Student> studentList = new List<Student>();

        public static void listAllExercises()
        {
            foreach (Exercise exercise in _allExercises)
            {
                Console.WriteLine(exercise.Name);
            }
        }
        public string Name;
        public string Language;

        public Exercise(string exName, string exLanguage)
        {
            Name = exName;
            Language = exLanguage;
            _allExercises.Add(this);
        }
    }
}