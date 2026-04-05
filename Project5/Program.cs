using System;

Console.WriteLine("--- Dynamic Times Table Generator ---");

// Loop to get a valid number from the user
int limit = 0;
while (true)
{
    Console.Write("How many times tables would you like to see? (Enter a number): ");
    string input = Console.ReadLine() ?? "";

    // Using a switch expression to parse and validate
    bool success = int.TryParse(input, out int result) switch
    {
        true when result > 0 => (limit = result) > 0, // Assignment and validation
        _ => false
    };

    if (success) break;

    Console.WriteLine("Please enter a valid positive integer.");
}

PrintTable(limit);

// Local function to handle the display logic
static void PrintTable(int max)
{
    Console.WriteLine($"\nMultiplication Table: 1 to {max}\n");

    // Print Column Header
    Console.Write("    ");
    for (int i = 1; i <= max; i++) Console.Write($"{i,5}");
    Console.WriteLine("\n" + new string('-', (max * 5) + 4));

    for (int row = 1; row <= max; row++)
    {
        // Print Row Header
        Console.Write($"{row,2} |");

        for (int col = 1; col <= max; col++)
        {
            // Calculate and format with 5 spaces of padding
            Console.Write($"{row * col,5}");
        }
        Console.WriteLine();
    }
}











//using System;

//Console.WriteLine("Multiplication Table (1-10):");
//Console.WriteLine();

//// Print header row
//Console.Write("    ");
//for (int i = 1; i <= 10; i++) Console.Write($"{i,4}");
//Console.WriteLine("\n" + new string('-', 45));

//// Nested loops to generate the table
//for (int row = 1; row <= 10; row++)
//{
//    // Print row header
//    Console.Write($"{row,2} |");

//    for (int col = 1; col <= 10; col++)
//    {
//        // Use a switch-like logic or direct calculation
//        int result = row * col;

//        // Formatting: {result, 4} ensures each number takes up 4 spaces for alignment
//        Console.Write($"{result,4}");
//    }
//    Console.WriteLine();
//}