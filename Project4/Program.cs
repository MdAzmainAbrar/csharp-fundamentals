using System;
using System.Linq;

// .NET 10 Top-Level Statements
Console.WriteLine("--- .NET 10 Credit Card Masker ---");

string input;

// Validation loop
while (true)
{
    Console.Write("Enter credit card number: ");
    input = Console.ReadLine() ?? "";

    // Using a modern switch expression for validation
    bool isValid = input switch
    {
        { Length: 0 } => false,
        var s when !s.Any(char.IsDigit) => false,
        _ => true
    };

    if (isValid) break;

    Console.WriteLine("Invalid input. Please ensure you enter numbers.");
}

Console.WriteLine($"Masked Output: {MaskCreditCard(input)}");

static string MaskCreditCard(string input)
{
    Span<char> chars = input.ToCharArray();
    int alphanumericCount = 0;

    for (int i = chars.Length - 1; i >= 0; i--)
    {
        // Using a switch expression with pattern matching instead of if-else
        chars[i] = chars[i] switch
        {
            var c when char.IsLetterOrDigit(c) => ++alphanumericCount > 4 ? 'X' : c,
            var c => c // Keeps spaces, dashes, etc. as they are
        };
    }

    return new string(chars);
}


//using System;
//using System.Linq; // Needed for the .Any() method

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("--- Credit Card Masker ---");

//        string input = "";
//        bool isValid = false;

//        // Loop until the user provides valid input
//        while (!isValid)
//        {
//            Console.Write("Enter credit card number: ");
//            input = Console.ReadLine();

//            // Validation: Check if the string is empty or contains NO digits
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                Console.WriteLine("Error: Input cannot be empty.");
//            }
//            else if (!input.Any(char.IsDigit))
//            {
//                Console.WriteLine("Error: The input must contain at least some numbers.");
//            }
//            else
//            {
//                isValid = true; // Break the loop
//            }
//        }

//        string maskedResult = MaskCreditCard(input);
//        Console.WriteLine($"Masked Output: {maskedResult}");
//    }

//    static string MaskCreditCard(string input)
//    {
//        char[] chars = input.ToCharArray();
//        int seenAlphanumeric = 0;

//        // Iterate backwards
//        for (int i = chars.Length - 1; i >= 0; i--)
//        {
//            char c = chars[i];

//            if (char.IsDigit(c) || char.IsLetter(c))
//            {
//                seenAlphanumeric++;

//                if (seenAlphanumeric > 4)
//                {
//                    chars[i] = 'X';
//                }
//            }
//        }

//        return new string(chars);
//    }
//}