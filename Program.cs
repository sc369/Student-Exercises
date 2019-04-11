using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stephenClark = new Student("Stephen", "Clark", "sc369");
            Student ryanDillinger = new Student("Ryan", "Dillinger", "Joseph Gordon Levitt");
            Student samCronin = new Student("Sam", "Cronin", "samCronin555");
            Student ryanNelson = new Student("Ryan", "Nelson", "ryanNelson324");
            Cohort dayCohort30 = new Cohort("Day Cohort 30");
            Cohort eveningCohort7 = new Cohort("Evening Cohort 7");
            Cohort dayCohort32 = new Cohort("Day Cohort 32");

            Exercise welcomeToNashville = new Exercise("Welcome To Nashville", "JavaScript");
            Exercise reactNutshell = new Exercise("React Nutshell", "React");
            Exercise stocks = new Exercise("Stocks", "C#");
            Exercise classes = new Exercise("Classes", "C#");

            Instructor steveBrownlee = new Instructor("Steve", "Brownlee", "goldenrod329");
            Instructor jennaSolis = new Instructor("Jenna", "Solis", "SirPimpsALot");
            Instructor kimmyBird = new Instructor("Kimmy", "Bird", "KB867");

            steveBrownlee.assignExercise(welcomeToNashville, stephenClark);
            steveBrownlee.assignExercise(reactNutshell, stephenClark);

            jennaSolis.assignExercise(reactNutshell, ryanDillinger);
            jennaSolis.assignExercise(classes, ryanDillinger);

            kimmyBird.assignExercise(reactNutshell, samCronin);
            kimmyBird.assignExercise(classes, samCronin);

            steveBrownlee.assignExercise(stocks, ryanNelson);
            steveBrownlee.assignExercise(reactNutshell, ryanNelson);

            dayCohort30.addStudent(stephenClark);
            dayCohort30.addStudent(ryanDillinger);
            dayCohort30.addStudent(ryanNelson);
            dayCohort30.addStudent(samCronin);

            dayCohort30.addInstructor(steveBrownlee);
            dayCohort30.addInstructor(jennaSolis);
            dayCohort30.addInstructor(kimmyBird);

            // dayCohort30.listStudents();
            // dayCohort30.listInstructors();

            List<Student> studentList = new List<Student>();

            // Student.listAllStudents();
            // Exercise.listAllExercises();

            // stephenClark.displayStudentExercises();
            Student.displayAllStudentExercises();



        }
    }
}
