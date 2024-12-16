using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    // LINQ class
    public class LINQ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // List of employees
        //    List<LINQ> employees = new List<LINQ>
        //    {
        //        new LINQ { Id = 1, Name = "Monika", Salary = 100000, Address = "Bagbazar" },
        //        new LINQ { Id = 2, Name = "Rosa", Salary = 1000000, Address = "Pokhara" },
        //        new LINQ { Id = 3, Name = "Manisha", Salary = 10000, Address = "Kathmandu" },
        //        new LINQ { Id = 4, Name = "Samjhana", Salary = 100000, Address = "Lalitpur" },
        //        new LINQ { Id = 5, Name = "Smiriti", Salary = 90000, Address = "Kathmandu" }
        //    };

        //    // LINQ Query: Select employees with Salary > 50000 and Address = "Kathmandu"
        //    var selectedEmployees = employees
        //        .Where(emp => emp.Salary > 50000 && emp.Address == "Kathmandu");

        //    // Display the filtered employees
        //    Console.WriteLine("Employees with Salary > 50000 and Address = Kathmandu:");
        //    foreach (var emp in selectedEmployees)
        //    {
        //        Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
        //    }

        //    Console.ReadLine();
        //}
    }
}
