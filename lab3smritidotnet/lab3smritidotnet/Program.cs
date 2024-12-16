using System;

namespace MulticastDelegateExample
{
    // Step 1: Define a delegate
    delegate void Notify(string message);

    class la1
    {
    //    static void Main(string[] args)
    //    {
    //        // Step 2: Create methods that match the delegate signature
    //        void ShowMessage1(string message)
    //        {
    //            Console.WriteLine($"Message from Method 1: {message}");
    //        }

    //        void ShowMessage2(string message)
    //        {
    //            Console.WriteLine($"Message from Method 2: {message}");
    //        }

    //        // Step 3: Create a multicast delegate
    //        Notify notifyDelegate = null;

    //        // Add methods to the delegate
    //        notifyDelegate += ShowMessage1;
    //        notifyDelegate += ShowMessage2;

    //        // Step 4: Invoke the multicast delegate
    //        Console.WriteLine("Invoking the multicast delegate:");
    //        notifyDelegate?.Invoke("Hello, Multicast Delegate!");

    //        // Step 5: Remove a method from the delegate
    //        notifyDelegate -= ShowMessage1;

    //        Console.WriteLine("\nAfter removing Method 1:");
    //        notifyDelegate?.Invoke("This is after modification!");

    //        Console.ReadLine();
    //    }
    }
}
