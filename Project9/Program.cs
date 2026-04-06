////To see how far C# has come, let’s compare the "Old Way" (C# 5/6 style) with the "Modern Way" (C# 12 style).

////The goal of the code is the same: Define a question, ask the user, and check the result.
////1. The "Old Way" (Verbose & Heavy)
////In older versions, you had to write a lot of "boilerplate" (repetitive code) just to set up a simple data object.

//// OLD: You had to define a full Class with a Constructor
//public class QuizQuestion
//{
//    public string Text { get; set; }
//    public string Answer { get; set; }

//    public QuizQuestion(string text, string answer)
//    {
//        Text = text;
//        Answer = answer;
//    }
//}

//// OLD: Initializing a list was wordy
//List<QuizQuestion> quiz = new List<QuizQuestion>();
//quiz.Add(new QuizQuestion("Capital of France?", "Paris"));

//// OLD: Comparison required manual casing
//string input = Console.ReadLine();
//if (input != null && input.Trim().ToLower() == quiz[0].Answer.ToLower())
//{
//    Console.WriteLine("Correct");
//}

////2.The "Modern Way"(Lean & Readable)
////Modern C# focuses on "Records" and "Expressions." It cuts out the noise so you only see the logic.

//// NEW: A "Record" does everything the 12-line class above did in ONE line
//record QuizQuestion(string Text, string Answer);

//// NEW: Collection Expression [ ] 
//List<QuizQuestion> quiz = [new("Capital of France?", "Paris")];

//// NEW: Target-typed 'new' (you don't have to repeat the class name)
//// NEW: Comparison using OrdinalIgnoreCase (Faster and cleaner)
//string input = Console.ReadLine() ?? "";

//if (input.Trim().Equals(quiz[0].Answer, StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("✅ Correct");
//}


//using static System.Net.Mime.MediaTypeNames;

//Let’s build a Modern "Task Tracker" (To-Do List). This is a classic real-world scenario for any developer.

//We will use Records, Collection Expressions, Primary Constructors, and Lambda-based methods to make it look like professional 2026-standard C# code.

//The Scenario: "The Office Task Manager"
//Imagine you are at your office laptop and you want a quick way to add tasks and see them in a formatted list.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Collections.Generic; // <--- Make sure this is at the TOP

//// 1. MODERN DATA STRUCTURE: A Record with a Primary Constructor
//// This one line replaces an entire class. 'IsDone' has a default value of false.
//record TodoTask(string Title, string Category, bool IsDone = false);

// 2. MODERN COLLECTION: Using [ ] instead of new List<TodoTask>()
//List<TodoTask> officeTasks = [
//    new("Push Project 7 to GitHub", "Work"),
//    new("Fix VS Path Error", "Technical"),
//    new("Buy Coffee", "Personal", IsDone: true)
//];

// Try adding 'TodoTask' explicitly if the empty 'new' is red
//List<TodoTask> officeTasks = [
//    new TodoTask("Push Project 7 to GitHub", "Work"),
//    new TodoTask("Fix VS Path Error", "Technical"),
//    new TodoTask("Buy Coffee", "Personal", true)
//];

//Console.WriteLine("""
//    === OFFICE TASK MANAGER ===
//    Current Status:
//    """);

//// 3. MODERN LOGIC: Using a method to process the list
//DisplayTasks(officeTasks);

//// 4. ADDING A NEW TASK (The Interactive Part)
//Console.Write("\nEnter new task title: ");
//string newTitle = Console.ReadLine() ?? "Untitled";

//// Adding to the list using the shorthand 'new'
//officeTasks.Add(new(newTitle, "Work"));

//Console.WriteLine("\nUpdated List:");
//DisplayTasks(officeTasks);

//// --- MODERN METHODS ---

//void DisplayTasks(List<TodoTask> tasks)
//{
//    // Using LINQ and String Interpolation
//    foreach (var task in tasks)
//    {
//        // Modern Switch Expression to choose an emoji
//        string statusEmoji = task.IsDone switch
//        {
//            true => "✅",
//            false => "⏳"
//        };

//        Console.WriteLine($"{statusEmoji} [{task.Category.ToUpper()}] {task.Title}");
//    }
//}


using System;
using System.Collections.Generic;

// ==========================================
// 1. TOP-LEVEL STATEMENTS (The logic goes first)
// ==========================================

int score = 0;

// Collection Expression [ ] - Modern .NET 10 syntax
List<QuizQuestion> quiz = [
    new("What is the capital of France?", "Paris"),
    new("What is the capital of Japan?", "Tokyo"),
    new("What is the capital of Germany?", "Berlin"),
    new("What is the capital of Italy?", "Rome")
];

Console.WriteLine("""
    *******************************************
    * MODERN .NET 10 GEOGRAPHY QUIZ           *
    *******************************************
    """);

foreach (var q in quiz)
{
    Console.Write($"\n{q.Text} ");
    string userResponse = Console.ReadLine() ?? "";

    if (CheckAnswer(userResponse, q.Answer))
    {
        Console.WriteLine("✅ Correct! +1 Point");
        score++;
    }
    else
    {
        Console.WriteLine($"❌ Wrong. The correct answer is {q.Answer}.");
    }
}

Console.WriteLine("\n-------------------------------------------");
Console.WriteLine($"Quiz Over! Final Score: {score}/{quiz.Count}");

// Modern Switch Expression
string feedback = score switch
{
    4 => "Perfect Score! You are a genius!",
    3 => "Great job! Almost perfect.",
    2 => "Not bad, but you could study more.",
    _ => "Keep practicing. You'll get it!"
};

Console.WriteLine($"Result: {feedback}");

// ==========================================
// 2. METHODS (Local functions follow logic)
// ==========================================

// Comparing UTF-16 code units while ignoring case
bool CheckAnswer(string guess, string actual)
    => guess.Trim().Equals(actual, StringComparison.OrdinalIgnoreCase);

// ==========================================
// 3. TYPE DECLARATIONS (Records/Classes go LAST)
// ==========================================

// Primary Constructor Record
record QuizQuestion(string Text, string Answer);