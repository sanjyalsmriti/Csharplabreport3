using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDatabaseOperations
{
    // Employee class definition
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        // In-memory list of employees simulating a database table
        static List<Employee> employees = new List<Employee>();

        //static void Main(string[] args)
        //{
        //    // Adding initial employees
        //    InsertEmployee("John Doe", 60000, "Kathmandu");
        //    InsertEmployee("Jane Smith", 45000, "Pokhara");
        //    InsertEmployee("Ram Shrestha", 75000, "Kathmandu");
        //    InsertEmployee("Sita Rana", 40000, "Lalitpur");
        //    InsertEmployee("Hari KC", 55000, "Kathmandu");

        //    // Display employees before edit and delete
        //    Console.WriteLine("\nBefore Edit and Delete:");
        //    DisplayEmployees();

        //    // Edit Employee details
        //    EditEmployee(1, "John Doe", 65000, "Bhaktapur");

        //    // Delete an Employee
        //    DeleteEmployee(3);

        //    // Display employees after edit and delete
        //    Console.WriteLine("\nAfter Edit and Delete:");
        //    DisplayEmployees();
        //}

        //// Simulated Insert Operation
        //static void InsertEmployee(string name, double salary, string address)
        //{
        //    int id = employees.Count + 1; // Generate a unique Id for each employee
        //    Employee newEmployee = new Employee
        //    {
        //        Id = id,
        //        Name = name,
        //        Salary = salary,
        //        Address = address
        //    };
        //    employees.Add(newEmployee);
        //    Console.WriteLine($"{name} inserted successfully.");
        //}

        //// Simulated Edit Operation
        //static void EditEmployee(int id, string newName, double newSalary, string newAddress)
        //{
        //    var employee = employees.FirstOrDefault(emp => emp.Id == id);
        //    if (employee != null)
        //    {
        //        employee.Name = newName;
        //        employee.Salary = newSalary;
        //        employee.Address = newAddress;
        //        Console.WriteLine($"Employee with ID {id} updated successfully.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Employee with ID {id} not found.");
        //    }
        //}

        //// Simulated Delete Operation
        //static void DeleteEmployee(int id)
        //{
        //    var employee = employees.FirstOrDefault(emp => emp.Id == id);
        //    if (employee != null)
        //    {
        //        employees.Remove(employee);
        //        Console.WriteLine($"Employee with ID {id} deleted successfully.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Employee with ID {id} not found.");
        //    }
        //}

        //// Display all employees
        //static void DisplayEmployees()
        //{
        //    if (employees.Count == 0)
        //    {
        //        Console.WriteLine("No employees to display.");
        //        return;
        //    }

        //    foreach (var emp in employees)
        //    {
        //        Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
        //    }
        //}
    }
}
