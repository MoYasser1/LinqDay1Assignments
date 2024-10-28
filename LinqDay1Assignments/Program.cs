using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace LinqDay1Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 -Declare a List of numbers as shown :   
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            //Then write the following queries
            #region Display numbers without any repeated Data and sorted  
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            //var query1 = numbers.Distinct().OrderBy(n => n);
            //foreach (var number in query1)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region using Query1  result and show each number and it’s multiplication  
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            //var query1 = numbers.Distinct().OrderBy(n => n);
            //var query2 = query1.Select(n => new { Number = n, Multiplication = n * n });
            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"Number: {item.Number}, Multiplication: {item.Multiplication}");
            //}
            #endregion
            //2-declare an array of names as shown :   
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            #region Query1: Select names with length equal 3. o / p should be as
            //        string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //var result = names.Where(name => name.Length == 3);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion
            #region Query2: Select names that contains “a” letter (Capital or Small )then sort them 
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //var result = names
            //    .Where(name => name.IndexOf('a', StringComparison.OrdinalIgnoreCase) >= 0)
            //    .OrderBy(name => name.Length);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion
            #region Query3: Display the first 2 names  
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]); 
            #endregion
            //3 - Declare a class Subject that contains the following properties(Code, Name) and declare Student class 
            //that contains the following properties(ID, FirstName, LastName , Subject[]), then define List of students As
            //follow
            #region Query1: Display Full name and number of subjects for each student as follow  

            //List<Student> students = new List<Student>()
            //    new Student()
            //    {
            //        ID = 1,
            //        FirstName = "Mohamed",
            //        LastName = "Yasser",
            //        Subjects = new Subject[]
            //        {
            //            new Subject(){ Code = 22, Name = "EF" },
            //            new Subject(){ Code = 33, Name = "UML" }
            //        }
            //    },
            //    new Student()
            //    {
            //        ID = 2,
            //        FirstName = "Mona",
            //        LastName = "Gala",
            //        Subjects = new Subject[]
            //        {
            //            new Subject(){ Code = 22, Name = "EF" },
            //            new Subject(){ Code = 34, Name = "XML" },
            //            new Subject(){ Code = 25, Name = "JS" }
            //        }
            //    },
            //    new Student()
            //    {
            //        ID = 3,
            //        FirstName = "Yara",
            //        LastName = "Yousf",
            //        Subjects = new Subject[]
            //        {
            //            new Subject(){ Code = 22, Name = "EF" },
            //            new Subject(){ Code = 25, Name = "JS" }
            //        }
            //    },
            //    new Student()
            //    {
            //        ID = 4,
            //        FirstName = "Ali",
            //        LastName = "Ali",
            //        Subjects = new Subject[]
            //        {
            //            new Subject(){ Code = 33, Name = "UML" }
            //        }
            //    }
            //};
            //            var query1 = students.Select(s => new
            //            {
            //                FullName = $"{s.FirstName} {s.LastName}",
            //                NumberOfSubjects = s.Subjects.Length
            //            });

            //            foreach (var student in query1)
            //            {
            //                Console.WriteLine($"Full Name: {student.FullName}, Number of Subjects: {student.NumberOfSubjects}");
            //            }


            #endregion
            #region Query2: Write a query which orders the elements in the list by FirstName Descending then by LastName Ascending and result of query displays only first names and last names for the elements in list as follow  


            //    var query2 = students
            //.OrderByDescending(s => s.FirstName)
            //.ThenBy(s => s.LastName)
            //.Select(s => new
            //{
            //    s.FirstName,
            //    s.LastName
            //});

            //        foreach (var student in query2)
            //        foreach (var student in query2)
            //        {
            //            Console.WriteLine($"First Name: {student.FirstName}, Last Name: {student.LastName}");
            //        }

            #endregion
        }
    }
}
