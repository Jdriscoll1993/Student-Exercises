CREATE TABLE Cohort (
    id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    cohortName VARCHAR NOT NULL
);
SELECT * FROM Cohort;
INSERT INTO Cohort (cohortName) VALUES ('Day32');
INSERT INTO Cohort (cohortName) VALUES ('Day33');
INSERT INTO Cohort (cohortName) VALUES ('Day34');
INSERT INTO Cohort (cohortName) VALUES ('Day31');

CREATE TABLE Student(
    id INTEGER NOT NULL PRIMARY KEY IDENTITY, 
    firstName VARCHAR(20) NOT NULL,
    lastName VARCHAR(20) NOT NULL,
    slackHandle VARCHAR(20) NOT NULL,
    cohortId INTEGER
    CONSTRAINT FK_Student_Cohort FOREIGN KEY(cohortId) REFERENCES Cohort(id) 
);
SELECT * FROM Student;
INSERT INTO Student(firstName, lastName, slackHandle, cohortId) VALUES('Randy', 'BoBandy', '@TheRealRandy', 4);
INSERT INTO Student(firstName, lastName, slackHandle, cohortId) VALUES('Jim', 'Lahey', '@DrunkLahey', 5);
INSERT INTO Student(firstName, lastName, slackHandle, cohortId) VALUES('Barb', 'Lahey', '@BarbsPark', 6);
INSERT INTO Student(firstName, lastName, slackHandle, cohortId) VALUES('Corey', 'Lahey', '@SupDude', 6);
INSERT INTO Student(firstName, lastName, slackHandle, cohortId) VALUES('Philedelphia', 'Collins', '@TheDirtyBurger', 5);


CREATE TABLE Instructor(
    id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    firstName VARCHAR(20) NOT NULL,
    lastName VARCHAR(20) NOT NULL,
    slackHandle VARCHAR(20) NOT NULL,
    specialty VARCHAR(20),
    cohortId INTEGER NOT NULL,
    CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(cohortId) REFERENCES Cohort(id) 
);
SELECT * FROM Instructor;
INSERT INTO Instructor(firstName, lastName, slackHandle, specialty, cohortId) VALUES('Trevor', 'Dennison', '@TBag', 'JavaScript', 5);
INSERT INTO Instructor(firstName, lastName, slackHandle, specialty, cohortId) VALUES('Ricky', 'Sunnyvale', '@6PaperJ', 'C#/.NET', 7);
INSERT INTO Instructor(firstName, lastName, slackHandle, specialty, cohortId) VALUES('Julian', 'Sunnyvale', '@JulianRules', 'T-SQL', 4);

CREATE TABLE Exercise(
    id INT NOT NULL PRIMARY KEY IDENTITY,
    exerciseName VARCHAR(20) NOT NULL,
    progLanguage VARCHAR(20) NOT NULL,
    InstructorId INTEGER NOT NULL,
    CONSTRAINT FK_Exercise_Instructor FOREIGN KEY(InstructorId) REFERENCES Instructor(id)
);
SELECT * FROM Exercise;
INSERT INTO Exercise(exerciseName, progLanguage, InstructorId) VALUES ('Function Practice', 'JavaScript', 3 )
INSERT INTO Exercise(exerciseName, progLanguage, InstructorId) VALUES ('Array Methods', 'JavaScript', 3 )
INSERT INTO Exercise(exerciseName, progLanguage, InstructorId) VALUES ('Classes', 'C#', 4 )


CREATE TABLE StudentExercises(
    id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    exerciseId INT,
    studentId INT,
    CONSTRAINT FK_StudentExercises_Exercises FOREIGN KEY(exerciseId) REFERENCES Exercise(id),
    CONSTRAINT FK_StudentExercises_Students FOREIGN KEY(studentId) REFERENCES Student(id)
)
SELECT * FROM StudentExercises;
INSERT INTO StudentExercises(studentId, ExerciseId) VALUES (,);
