//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace InMemoryDatabaseExample
//{
//    // Employee class
//    public class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Salary { get; set; }
//        public string Address { get; set; }
//    }

//    class Program
//    {
//        // In-memory list of employees
//        static List<Employee> employees = new List<Employee>();

//    //    static void Main(string[] args)
//    //    {
//    //        // Insert operation (simulated as in-memory insert)
//    //        InsertEmployee("John Doe", 60000, "Kathmandu");
//    //        InsertEmployee("smirti", 45000, "Pokhara");
//    //        InsertEmployee("Ram Shrestha", 75000, "Kathmandu");
//    //        InsertEmployee("Sita Rana", 40000, "Lalitpur");
//    //        InsertEmployee("Hari KC", 55000, "Kathmandu");

//    //        // Select operation (simulated as in-memory query)
//    //        SelectEmployees();
//    //    }

//    //    // Insert employee (simulated as inserting into in-memory list)
//    //    static void InsertEmployee(string name, double salary, string address)
//    //    {
//    //        int id = employees.Count + 1; // Simulate auto-increment ID
//    //        Employee newEmployee = new Employee
//    //        {
//    //            Id = id,
//    //            Name = name,
//    //            Salary = salary,
//    //            Address = address
//    //        };
//    //        employees.Add(newEmployee);
//    //        Console.WriteLine($"Employee {name} inserted successfully.");
//    //    }

//    //    // Select employees (simulated as querying from in-memory list)
//    //    static void SelectEmployees()
//    //    {
//    //        Console.WriteLine("\nEmployees:");
//    //        var selectedEmployees = employees
//    //            .Where(emp => emp.Salary > 50000 && emp.Address == "Kathmandu")
//    //            .ToList();

//    //        foreach (var emp in selectedEmployees)
//    //        {
//    //            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
//    //        }
//    //    }
//    }
//}
