using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Exercise Exercise1 = new Exercise()
            {
                Name = "Function practice",
                Language = "JavaScript"
            };
            Exercise Exercise2 = new Exercise()
            {
                Name = "Array Methods",
                Language = "JavaScript"
            };
            Exercise Exercise3 = new Exercise()
            {
                Name = "Classes",
                Language = "C#"
            };
            Exercise Exercise4 = new Exercise()
            {
                Name = "Types",
                Language = "C#"
            };

            Cohort Day32 = new Cohort()
            {
                CohortName = "Cohort 32"
            };
            Cohort Day33 = new Cohort()
            {
                CohortName = "Cohort 33"
            };
            Cohort Day34 = new Cohort()
            {
                CohortName = "Cohort 34"
            };

            Student Randy = new Student()
            {
                FirstName = "Randy",
                LastName = "BoBandy",
                SlackHandle = "@TheRealRandy",
                Cohort = 32

            };

            Student Lahey = new Student()
            {
                FirstName = "Jim",
                LastName = "Lahey",
                SlackHandle = "@DrunkLahey",
                Cohort = 33

            };
            Student Barb = new Student()
            {
                FirstName = "Barb",
                LastName = "Lahey",
                SlackHandle = "@BarbsPark",
                Cohort = 34

            };

            Student Corey = new Student()
            {
                FirstName = "Corey",
                LastName = "Lahey",
                SlackHandle = "@SupDude",
                Cohort = 34

            };

            Day32.AddStudent(Randy);
            Day32.AddStudent(Lahey);
            Day32.AddStudent(Barb);
            Day32.AddStudent(Corey);

            Instructor Trevor = new Instructor()
            {
                FirstName = "Trevor",
                LastName = "Lahey",
                SlackHandle = "@TrevorBag",
                Cohort = 33

            };
            Instructor Ricky = new Instructor
            {
                FirstName = "Ricky",
                LastName = "Sunnyvale",
                SlackHandle = "@RickySan",
                Cohort = 31

            };
            Instructor Julian = new Instructor()
            {
                FirstName = "Julian",
                LastName = "Sunnyvale",
                SlackHandle = "@JulianRules",
                Cohort = 32

            };

            Day32.AddInstructor(Trevor);
            Day32.AddInstructor(Ricky);
            Day32.AddInstructor(Julian);

            Trevor.AssignStudents(Randy, Exercise1);
            Trevor.AssignStudents(Randy, Exercise2);

            Ricky.AssignStudents(Lahey, Exercise3);
            Ricky.AssignStudents(Lahey, Exercise4);

            Julian.AssignStudents(Barb, Exercise2);
            Julian.AssignStudents(Barb, Exercise4);

            Trevor.AssignStudents(Corey, Exercise1);
            Trevor.AssignStudents(Barb, Exercise3);

            List<Student> students = new List<Student>();

            students.Add(Randy);
            students.Add(Lahey);
            students.Add(Barb);
            students.Add(Corey);

            List<Exercise> exercises = new List<Exercise>();

            exercises.Add(Exercise1);
            exercises.Add(Exercise2);
            exercises.Add(Exercise3);
            exercises.Add(Exercise4);

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student.FirstName}");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Exercise: {exercise.Name}");
                }
            }
        }
    }
}
