using System;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }

        public void AssignStudents(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);

        }

    }
}