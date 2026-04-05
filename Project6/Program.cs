//test scores analyzer using LINQ and modern C# features
using System;
using System.Linq;
using System.Collections.Generic;

Console.WriteLine("--- Test Result Analyzer ---");

double[] scores;

while (true)
{
    Console.WriteLine("\nEnter test results separated by spaces or commas:");
    string input = Console.ReadLine() ?? "";

    // Split by common separators and remove empty entries
    string[] parts = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

    try
    {
        // Use LINQ to parse all parts into doubles
        scores = parts.Select(double.Parse).ToArray();

        // Validate that we actually have numbers
        if (scores.Length == 0) throw new Exception();

        break; // Success
    }
    catch
    {
        Console.WriteLine("Invalid input. Please enter a list of valid numbers.");
    }
}

// Perform calculations using LINQ
double best = scores.Max();
double worst = scores.Min();
double sum = scores.Sum();
double avg = scores.Average();

// Output formatting
Console.WriteLine("\n--- Analysis Results ---");
Console.WriteLine($"Total Scores Entered: {scores.Length}");
Console.WriteLine($"Sum:                  {sum}");
Console.WriteLine($"Best Score:           {best}");
Console.WriteLine($"Worst Score:          {worst}");
Console.WriteLine($"Average Score:        {avg:F2}"); // Formats to 2 decimal places

// Optional: A little visual feedback using a switch for "Grade Performance"
string performance = avg switch
{
    >= 90 => "Excellent",
    >= 75 => "Good",
    >= 50 => "Satisfactory",
    _ => "Needs Improvement"
};

Console.WriteLine($"Overall Performance:  {performance}");