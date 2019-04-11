using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string name { get; set; }
        public List<Instructor> instructorList { get; set; } = new List<Instructor>();
        public List<Student> studentList { get; set; } = new List<Student>();
        //Constructor
        public Cohort(string cohortName)
        {
            name = cohortName;
        }
        public void addStudent(Student student)
        {
            this.studentList.Add(student);
            Console.WriteLine($"{student.fullName} added to {this.name}");
        }

        public void addInstructor(Instructor instructor)
        {
            this.instructorList.Add(instructor);
            Console.WriteLine($"{instructor.fullName} added to {this.name}");
        }
        public void listStudents()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.fullName);
            }
        }
        public void listInstructors()
        {
            foreach (Instructor instructor in instructorList)
            {
                Console.WriteLine(instructor.fullName);

            }

        }








    }
}