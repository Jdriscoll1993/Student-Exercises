using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }

        public List<Exercise> Exercises = new List<Exercise>();

    }
}