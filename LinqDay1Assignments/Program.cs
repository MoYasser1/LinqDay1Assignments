using System.Collections.Generic;

namespace LinqDay1Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a List of numbers as shown :   
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
            //declare an array of names as shown :   
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


        }
    }
}
