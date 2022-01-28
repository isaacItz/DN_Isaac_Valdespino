// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Collections.Generic;
using Linq.Examples.Entities;

IList<Student> studentList = new List<Student>() {
    new Student() {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1},
    new Student() {StudentID = 2, StudentName = "Steve", Age = 20, StandardID = 1},
    new Student() {StudentID = 3, StudentName = "Bill", Age = 21, StandardID = 2},
    new Student() {StudentID = 4, StudentName = "Ram", Age = 22, StandardID = 2},
    new Student() {StudentID = 5, StudentName = "Ron", Age = 23}
};

IList<Standard> standardList = new List<Standard>() {
    new Standard() { StandardID = 1, StandardName = "Standard 1"},
    new Standard() { StandardID = 2, StandardName = "Stardnard 2"},
    new Standard() { StandardID = 3, StandardName = "Standard 3"}
};

var students = studentList.Where(x => x.Age > 21 && x.StandardID > 0)
    .Select(x => x.StudentName);
Console.WriteLine("students: " + students.Count());

var teenStudentsName = from s in studentList
                        where s.Age > 12 && s.Age < 20
                        select new { StudentName = s.StudentName };

var studentsGroupByStandard = from s in studentList
                            group s by s.StandardID into sg
                            orderby sg.Key
                            select new { 
                                StandardID = sg.Key,
                                Items = sg 
                                };

var studentsWithStandard = from s in studentList
                            join stand in standardList
                            on s.StandardID equals stand.StandardID
                            select new { 
                                StudentName = s.StudentName,
                                StandardName = stand.StandardName
                            };

foreach ( var element in studentsWithStandard ) {
    Console.WriteLine($"Student {element.StudentName} is in {element.StandardName}");
}

foreach ( var element in studentsGroupByStandard ) {
    Console.WriteLine(element.StandardID);
    foreach ( var student in element.Items ) {
        Console.WriteLine(student.StudentName);
    }
    Console.WriteLine();
}