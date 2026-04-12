//1.The Concept: What is Try - Catch ?
//In software development, things don't always go according to plan. A database might go offline,
//a user might type a word when you asked for a number, or a file you need to read might be missing.
//When these unexpected events happen, C# throws an Exception (an error). If you don't handle it, your program crashes.

//The try-catch block is your safety net.

//try: You put the "risky" code inside this block. You are telling the program,
//"Try to run this code, but keep an eye out for errors."

//catch: If an error happens in the try block, the program immediately stops what it's doing and jumps to the catch block.
//This is where you handle the problem (e.g., log the error, show a friendly message to the user).

//finally (Optional): This block runs no matter what—whether an error happened or not. It is usually used for cleanup,
//like closing a file or a database connection.

//2.Example Scenario: The Bank Withdrawal
//Let's imagine we are building a simple banking method that processes a withdrawal.
//Sometimes, network errors happen. Sometimes, the user requests more money than they have. We need to handle these exceptions.

//The "Older" Approach: Catching and Checking inside the Block
//In older versions of C# (before C# 6.0), if you wanted to handle a specific type of general exception based on
//its properties (like an HTTP error code or a specific error message), you had to catch the exception first,
//and then use if/else statements inside the catch block to figure out what to do.

//Question: How do we handle a general exception differently based on its error message using the traditional approach?

//Answer:

//using System;

//public class BankSystem
//{
//    public void ProcessWithdrawal_OldWay(int amount)
//    {
//        try
//        {
//            // Simulating a risky operation
//            Console.WriteLine($"Attempting to withdraw ${amount}...");
//            throw new Exception("NetworkTimeout"); // Simulating an error
//        }
//        catch (InvalidOperationException ex)
//        {
//            // Catching a specific exception type is easy
//            Console.WriteLine($"Logic Error: {ex.Message}");
//        }
//        catch (Exception ex)
//        {
//            // OLD APPROACH: Catch the general exception, then check conditions inside.
//            if (ex.Message == "NetworkTimeout")
//            {
//                Console.WriteLine("Old Approach: The network timed out. Please try again later.");
//            }
//            else if (ex.Message == "InsufficientFunds")
//            {
//                Console.WriteLine("Old Approach: You do not have enough money.");
//            }
//            else
//            {
//                // If we don't know how to handle it, we have to throw it back up.
//                // This is bad because it resets part of the error's "stack trace" (history).
//                throw;
//            }
//        }
//        finally
//        {
//            Console.WriteLine("Transaction attempt finished.\n");
//        }
//    }
//}

//Why this wasn't ideal: If the exception didn't match our if conditions, 
//    we had to re-throw it (throw;). This could sometimes mess up debugging information (the stack trace) 
//        and resulted in clunky, nested code.


//The "Newer" Approach: Exception Filters (when keyword)
//Starting in C# 6.0, Microsoft introduced Exception Filters. You can now append a when condition directly to the catch statement.

//Question: How can we use modern C# Exception Filters to handle specific error conditions cleanly?

//Answer:

//using System;

//public class BankSystem
//{
//    public void ProcessWithdrawal_NewWay(int amount)
//    {
//        try
//        {
//            // Simulating a risky operation
//            Console.WriteLine($"Attempting to withdraw ${amount}...");
//            throw new Exception("NetworkTimeout"); // Simulating an error
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Logic Error: {ex.Message}");
//        }
//        // NEW APPROACH: Exception Filters using the 'when' keyword.
//        catch (Exception ex) when (ex.Message == "NetworkTimeout")
//        {
//            // This block ONLY runs if the condition in the 'when' clause is true.
//            Console.WriteLine("New Approach: The network timed out. Please try again later.");
//        }
//        catch (Exception ex) when (ex.Message == "InsufficientFunds")
//        {
//            Console.WriteLine("New Approach: You do not have enough money.");
//        }
//        // Notice we don't need a generic 'catch' with a 'throw' inside it anymore.
//        // If an exception happens that isn't a NetworkTimeout or InsufficientFunds,
//        // the program simply ignores these catch blocks and lets the error bubble up naturally,
//        // preserving the perfect debugging history (stack trace).
//        finally
//        {
//            Console.WriteLine("Transaction attempt finished.\n");
//        }
//    }
//}
//Why the New Approach is Better: Cleaner Code: It reads like plain English (catch Exception when ...).

//No if/else clutter: You avoid deep nesting inside your catch blocks. Better Debugging: Because the catch block is never 
//    even entered if the when condition is false, the original error state (stack trace) is perfectly preserved if the error 
//    is passed up to a higher level of your program.

//The most likely reason you are seeing a build error is that if you copied both code blocks directly into your file,
//your program now has two classes with the exact same name (public class BankSystem). C# won't allow two classes to
//share a name in the same file/namespace.
//Another common reason is that your project might be missing the Main method, which C# requires as the starting point to
//actually run a console application.
//Let's fix this by combining everything into a single, fully functioning file that includes both approaches
//and a Main method to run them.
//The Complete, Error-Free Code
//Replace everything in your file (usually Program.cs) with this combined version. It puts both the old and new methods into a single BankSystem class and runs them so you can see the output.

using System;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExceptionHandlingDemo
{
    public class BankSystem
    {
        // 1. The Older Approach
        public void ProcessWithdrawal_OldWay(int amount)
        {
            try
            {
                Console.WriteLine($"Attempting to withdraw ${amount}...");
                throw new Exception("NetworkTimeout");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Logic Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                if (ex.Message == "NetworkTimeout")
                {
                    Console.WriteLine("Old Approach: The network timed out. Please try again later.");
                }
                else if (ex.Message == "InsufficientFunds")
                {
                    Console.WriteLine("Old Approach: You do not have enough money.");
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                Console.WriteLine("Transaction attempt finished.\n");
            }
        }

        // 2. The Newer Approach (C# 6.0+)
        public void ProcessWithdrawal_NewWay(int amount)
        {
            try
            {
                Console.WriteLine($"Attempting to withdraw ${amount}...");
                throw new Exception("NetworkTimeout");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Logic Error: {ex.Message}");
            }
            catch (Exception ex) when (ex.Message == "NetworkTimeout")
            {
                Console.WriteLine("New Approach: The network timed out. Please try again later.");
            }
            catch (Exception ex) when (ex.Message == "InsufficientFunds")
            {
                Console.WriteLine("New Approach: You do not have enough money.");
            }
            finally
            {
                Console.WriteLine("Transaction attempt finished.\n");
            }
        }
    }

    // 3. The Entry Point to run the code
    class Program
    {
        static void Main(string[] args)
        {
            BankSystem bank = new BankSystem();

            Console.WriteLine("--- Testing Older Approach ---");
            bank.ProcessWithdrawal_OldWay(100);

            Console.WriteLine("--- Testing Newer Approach ---");
            bank.ProcessWithdrawal_NewWay(100);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

//Why this fixes the error:
//One Class: We merged both methods into a single BankSystem class.

//A Starting Point: We added class Program with a static void Main method.This tells C# exactly where to begin executing the code when you click "Run" or "Build".

//Give that a run in your editor. It should build successfully and print out the results of both approaches!

