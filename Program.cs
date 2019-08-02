using System;
using System.Collections.Generic;
using System.Linq;

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
            Student Phil = new Student()
            {
                FirstName = "Philedelpiha",
                LastName = "Collins",
                SlackHandle = "@TheDirtyBurger",
                Cohort = 33

            };
            Day32.AddStudent(Randy);
            Day32.AddStudent(Lahey);
            Day32.AddStudent(Barb);
            Day32.AddStudent(Corey);

            Instructor Trevor = new Instructor()
            {
                FirstName = "Trevor",
                LastName = "Dennision",
                SlackHandle = "@TBag",
                Cohort = 33,
                Specialty = "JavaScript"

            };
            Instructor Ricky = new Instructor
            {
                FirstName = "Ricky",
                LastName = "Sunnyvale",
                SlackHandle = "@RickySan",
                Cohort = 31,
                Specialty = "C#/.NET"

            };
            Instructor Julian = new Instructor()
            {
                FirstName = "Julian",
                LastName = "Sunnyvale",
                SlackHandle = "@JulianRules",
                Cohort = 32,
                Specialty = "SQL"

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

            List<Cohort> cohorts = new List<Cohort>();
            cohorts.Add(Day32);
            cohorts.Add(Day33);
            cohorts.Add(Day34);

            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(Trevor);
            instructors.Add(Ricky);
            instructors.Add(Julian);

            List<Student> students = new List<Student>();
            students.Add(Randy);
            students.Add(Lahey);
            students.Add(Barb);
            students.Add(Corey);
            students.Add(Phil);

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

            var jsExercises = (from exercise in exercises
                               where exercise.Language == "JavaScript"
                               select exercise);

            jsExercises.ToList().ForEach(ex => Console.WriteLine($"list of JS exercises: {ex.Name}"));

            var studentsInCohort = (from student in students
                                    where student.Cohort == 34
                                    select student);

            studentsInCohort.ToList().ForEach(student => Console.WriteLine($"Cohort 34 members: {student.FirstName}{student.LastName}"));

            var instructorsInCohort = (from instructor in instructors
                                       where instructor.Cohort == 33
                                       select instructor);

            instructorsInCohort.ToList().ForEach(instructor => Console.WriteLine($"Cohort 33 Instructor: {instructor.FirstName} {instructor.LastName}"));

            var studentsByLast = students.OrderBy(student => student.LastName).ToList();

            Console.WriteLine("Students by last name:");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}");
            }

            var notWorkingOnShit = (from student in students
                                    where student.Exercises.Count == 0
                                    select student);

            notWorkingOnShit.ToList().ForEach(student => Console.WriteLine($"Students not working on any exercises: {student.FirstName} {student.LastName}"));


            var mostExercises = students.OrderByDescending(student => student.Exercises.Count()).Take(1);

            Console.WriteLine("Student with the most exercises assigned: ");
            foreach (Student student in mostExercises)
            {
                Console.WriteLine(student.FirstName);
            }

            foreach (var cohort in cohorts)
            {
                Console.WriteLine($"{cohort.CohortName} has {cohort.Students.Count()} students");
            }









        }
    }
}
