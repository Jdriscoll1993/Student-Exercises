using System;

namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public void AssignStudents(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);

        }

    }
}