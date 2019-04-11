using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        private static List<Student> _allStudents = new List<Student>();

        public static void listAllStudents()
        {
            foreach (Student student in _allStudents)
            {
                Console.WriteLine(student.fullName);
            }
        }
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
        public List<Exercise> exerciseList = new List<Exercise>();

        public void displayStudentExercises()
        {
            {
                Console.WriteLine($"{this.fullName} is working on the following exercises:\n");
                foreach (Exercise exercise in this.exerciseList)
                {
                    Console.WriteLine($"{exercise.Name}");
                }
                Console.WriteLine();
            }

            //  public override string ToString()
            // {
            //             return $@"
            // {_address}
            // -------------------------
            // Designed by {_designer}
            // Constructed on {_dateConstructed}
            // Owned by {_owner}
            // {Volume} cubic meters of space.";
            //         }
        }
        public static void displayAllStudentExercises()
        {
            foreach (Student student in _allStudents)
            {
                student.displayStudentExercises();
            }
        }
        // Constructor
        public Student(string firstName, string lastName, string slackHandle)
        {
            _firstName = firstName;
            _lastName = lastName;
            _slackHandle = slackHandle;
            _allStudents.Add(this);
        }
    }
}