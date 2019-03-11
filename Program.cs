using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        //Assign a student to a cort
        static void AssignStudentCohort(Student student, Cohort cohort) => cohort.StudentList.Add(student);
        //assign instructor to a cohort
        static void AssignInstructorCohort(Instructors instructors, Cohort cohort) => cohort.InstructorList.Add(instructors);
        static void Main()
        {
            //===============================Create 4 or more exercises==========================
            Exercises exerciseOne = new Exercises("Iterating Planets", "C#");
            Exercises exerciseTwo = new Exercises("Kennel", "Reacj.js");
            Exercises exerciseThree = new Exercises("CSS Selectors", "CSS");
            Exercises exerciseFour = new Exercises("Semantic Tags", "HTML");

            // exerciseOne.ListExercises();
            // exerciseTwo.ListExercises();
            // exerciseThree.ListExercises();
            // exerciseFour.ListExercises();

            Console.WriteLine("=========================================================");

            //=========================Create 3, or more, cohorts.=========================
            Cohort Cohort29 = new Cohort("Cohort29");
            Cohort Cohort30 = new Cohort("Cohort30");
            Cohort Cohort31 = new Cohort("Cohort31");

            //============================Create 4, or more, students=====================
            Student firstStudent = new Student("Hunter", "Metts", "H-metty");
            Student SecondStudent = new Student("Nick", "Hansen", "nickHanses");
            Student ThirdStudent = new Student("Asia", "Carter", "AC/DC");
            Student FourthStudent = new Student("Tammy", "toolews", "LoosetGoosey");

            //=====================assign them to one of the cohorts.=========================
            AssignStudentCohort(firstStudent, Cohort29);
            AssignStudentCohort(SecondStudent, Cohort30);
            AssignStudentCohort(ThirdStudent, Cohort31);
            AssignStudentCohort(FourthStudent, Cohort29);

            //=============================Create Three Instructors=============================
            Instructors Jisie = new Instructors("Jisie", "David", "JuiceBox", "Cohort30");
            Instructors Andy = new Instructors("Andy", "Collins", "Caprisun", "Cohort29");
            Instructors Steve = new Instructors("Steve", "Brownlee", "Gatorade", "Cohort31");

            //ConsoleWrite the list of instructors.
            // Jisie.ListInstructors();
            // Andy.ListInstructors();
            // Steve.ListInstructors();

            //========================assing them to a cohort===================================
            AssignInstructorCohort(Jisie, Cohort30);
            AssignInstructorCohort(Andy, Cohort29);
            AssignInstructorCohort(Steve, Cohort31);

            //Have each instructor assign 2 exercises to each student

            // Cohort 30
            Jisie.AssignExercises(SecondStudent, exerciseTwo);
            Jisie.AssignExercises(SecondStudent, exerciseFour);

            //Cohort 29
            Andy.AssignExercises(firstStudent, exerciseOne);
            Andy.AssignExercises(firstStudent, exerciseFour);

            Andy.AssignExercises(FourthStudent, exerciseFour);
            Andy.AssignExercises(FourthStudent, exerciseTwo);

            //Cohort 31
            Steve.AssignExercises(ThirdStudent, exerciseOne);
            Steve.AssignExercises(ThirdStudent, exerciseThree);

            //student exercise Challenge
            List<Student> students = new List<Student>(){firstStudent, SecondStudent, ThirdStudent, FourthStudent};
            List<Exercises> exercises = new List<Exercises>(){exerciseOne, exerciseTwo, exerciseThree, exerciseFour};  

            //Generate a report saying which students are workig on what exercises
            foreach (Student student in students) {

                List<string> assignedExercises = new List<string>();

                foreach (Exercises exercise in student.StudentExercises) {
                    assignedExercises.Add(exercise.ExerciseName);
                }
                string exerciseList = String.Join(", ", assignedExercises);
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on the following exercises: {exerciseList}");
            }

        }
    }
}
