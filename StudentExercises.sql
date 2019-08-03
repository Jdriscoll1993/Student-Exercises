CREATE TABLE Cohort (
    ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
    CohortName VARCHAR(20) NOT NULL
);

SELECT * FROM Cohort;
INSERT INTO Cohort (CohortName) VALUES ('Day31');
INSERT INTO Cohort (CohortName) VALUES ('Day32');
INSERT INTO Cohort (CohortName) VALUES ('Day33');
INSERT INTO Cohort (CohortName) VALUES ('Day34');


CREATE TABLE Student(
    ID INTEGER NOT NULL PRIMARY KEY IDENTITY, 
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    SlackHandle VARCHAR(20) NOT NULL,
    CohortID INTEGER NOT NULL
    CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortID) REFERENCES Cohort(ID) 
);
SELECT * FROM Student;
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortID) VALUES('Randy', 'BoBandy', '@TheRealRandy', 2);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortID) VALUES('Jim', 'Lahey', '@DrunkLahey', 3);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortID) VALUES('Barb', 'Lahey', '@BarbsPark', 4);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortID) VALUES('Corey', 'Lahey', '@SupDude', 4);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortID) VALUES('Philedelphia', 'Collins', '@TheDirtyBurger', 3);


CREATE TABLE Instructor(
    ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    SlackHandle VARCHAR(20) NOT NULL,
    specialty VARCHAR(20),
    CohortID INTEGER NOT NULL,
    CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortID) REFERENCES Cohort(ID) 
);
SELECT * FROM Instructor;
INSERT INTO Instructor(FirstName, LastName, SlackHandle, specialty, CohortID) VALUES('Trevor', 'Dennison', '@TBag', 'JavaScript', 3);
INSERT INTO Instructor(FirstName, LastName, SlackHandle, specialty, CohortID) VALUES('Ricky', 'Sunnyvale', '@6PaperJ', 'C#/.NET', 1);
INSERT INTO Instructor(FirstName, LastName, SlackHandle, specialty, CohortID) VALUES('Julian', 'Sunnyvale', '@JulianRules', 'T-SQL', 2);

CREATE TABLE Exercise(
    ID INT NOT NULL PRIMARY KEY IDENTITY,
    ExerciseName VARCHAR(20) NOT NULL,
    ProgramLanguage VARCHAR(20) NOT NULL,
    InstructorID INTEGER NOT NULL,
    CONSTRAINT FK_Exercise_Instructor FOREIGN KEY(InstructorID) REFERENCES Instructor(ID)
);
SELECT * FROM Exercise;
INSERT INTO Exercise(ExerciseName, ProgramLanguage, InstructorID) VALUES ('Function Practice', 'JavaScript', 1 )
INSERT INTO Exercise(ExerciseName, ProgramLanguage, InstructorID) VALUES ('Basic Queries', 'T-SQL', 3 )
INSERT INTO Exercise(ExerciseName, ProgramLanguage, InstructorID) VALUES ('Classes', 'C#', 2 )


CREATE TABLE StudentExercises(
    ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
    ExerciseID INT,
    StudentId INT,
    CONSTRAINT FK_StudentExercises_Exercises FOREIGN KEY(ExerciseID) REFERENCES Exercise(ID),
    CONSTRAINT FK_StudentExercises_Students FOREIGN KEY(StudentID) REFERENCES Student(ID)
);

SELECT sfn.FirstName,
sln.LastName,
c.CohortName,
e.ExerciseName,
ifn.FirstName,
iln.LastName

FROM StudentExercises se
LEFT JOIN Student sfn ON se.StudentID = sfn.ID
LEFT JOIN Student sln ON se.StudentID = sln.ID
LEFT JOIN Cohort c ON sln.CohortId = c.ID
LEFT JOIN Exercise e ON se.ExerciseId = e.ID
LEFT JOIN Instructor ifn ON e.InstructorID = ifn.ID
LEFT JOIN Instructor iln ON e.InstructorID = iln.ID

SELECT * FROM StudentExercises;
--need to complete data for this join table