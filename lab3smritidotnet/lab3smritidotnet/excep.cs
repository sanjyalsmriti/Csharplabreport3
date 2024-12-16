using System;

// Define the custom exception class
public class InvalidAgeException : Exception
{
    // Default constructor
    public InvalidAgeException() : base("Age cannot be less than 18.")
    {
    }

    // Constructor with custom message
    public InvalidAgeException(string message) : base(message)
    {
    }

    // Constructor with custom message and inner exception
    public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

namespace CustomExceptionDemo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter your age:");
        //        int age = Convert.ToInt32(Console.ReadLine());

        //        // Throw custom exception if age is less than 18
        //        if (age < 18)
        //        {
        //            throw new InvalidAgeException(); // Throws the custom exception
        //        }

        //        Console.WriteLine("Your age is valid.");
        //    }
        //    catch (InvalidAgeException ex)
        //    {
        //        // Catch the custom exception
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //    catch (Exception ex)
        //    {
        //        // Catch any other general exception
        //        Console.WriteLine($"Unexpected Error: {ex.Message}");
        //    }
        //}
    }
}
