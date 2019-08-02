using System;

namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public string Specialty { get; set; }
        public void AssignStudents(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);

        }

    }
}