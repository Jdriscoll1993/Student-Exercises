using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }

        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();

        public void AddStudent(Student name)
        {
            Students.Add(name);
        }
        public void AddInstructor(Instructor name)
        {
            Instructors.Add(name);
        }
    }
}