using System;

namespace StudentExercises
{
    class Instructor
    {
        private string _firstName;
        private string _lastName;
        public string fullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }

        private string _slackHandle;
        public string cohort { get; set; }

        public Instructor(string firstName, string lastName, string slackHandle)
        {
            _firstName = firstName;
            _lastName = lastName;
            _slackHandle = slackHandle;
        }
        public void assignExercise(Exercise exercise, Student student)
        {
            student.exerciseList.Add(exercise);
            exercise.studentList.Add(student);
            Console.WriteLine($"{exercise.Name} assigned by {this.fullName} to {student.fullName}");
        }
    }
}