//using System;

//namespace SimpleInterestApp
//{
//    class calc
//    {
//        // Custom Exception class for invalid input
//        public class InvalidInputException : Exception
//        {
//            public InvalidInputException(string message) : base(message)
//            {
//            }
//        }

//        static void Main(string[] args)
//        {
//            try
//            {
//                // Request user input
//                Console.WriteLine("Enter Principal amount: ");
//                double principal = Convert.ToDouble(Console.ReadLine());

//                Console.WriteLine("Enter Rate of Interest: ");
//                double rate = Convert.ToDouble(Console.ReadLine());

//                Console.WriteLine("Enter Time period (in years): ");
//                double time = Convert.ToDouble(Console.ReadLine());

//                // Validate input to prevent negative or zero values
//                if (principal <= 0 || rate <= 0 || time <= 0)
//                {
//                    throw new InvalidInputException("All input values must be greater than zero.");
//                }

//                // Calculate Simple Interest
//                double simpleInterest = (principal * rate * time) / 100;

//                // Display the result
//                Console.WriteLine($"The Simple Interest is: {simpleInterest}");
//            }
//            catch (FormatException ex)
//            {
//                // Catching input format exceptions (e.g., non-numeric values)
//                Console.WriteLine("Invalid input. Please enter numeric values.");
//            }
//            catch (InvalidInputException ex)
//            {
//                // Catching custom exceptions for invalid input
//                Console.WriteLine(ex.Message);
//            }
//            catch (Exception ex)
//            {
//                // Catching any other unforeseen errors
//                Console.WriteLine($"An error occurred: {ex.Message}");
//            }

//            // Wait for user input before closing the application
//            Console.WriteLine("\nPress any key to exit...");
//            Console.ReadKey();
//        }
//    }
//}
