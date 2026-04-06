//C# methods 

// Access modifier

//static or nothing
//Return daata type - INT , OBJECT, STRING, VOID, double, float, decimal, bool
//identifier - method name

//optional parameter list in parens() / default value
//   method signature - name and param list and does not include the return data type
//   / why? access modifier + return data type + identifier + parameter list
// overloading method- same method name but different parameter list

//passing by ref or out
//using static System.Net.Mime.MediaTypeNames;

//static int Abrar(out int a,out int b)
//{
//    a= 10;
//    b= 20; 
//    return a + b;
//}

//int num=1;
//int num2;

//Console.WriteLine(Abrar(out num, out num2));  // Named parameter
//Console.WriteLine(num);


//The "Price Calculator"
//Imagine you are building a small shop. You need to calculate the total price of an item after adding a 15% tax.
//Instead of doing the math manually everywhere in your code, we will create a method called CalculateTotal.

//Access Modifier(public): Who can see it? (Usually public or private).

//Return Type(double): What kind of answer does it give back? (A number, text, or void if it gives nothing).

//Method Name (CalculateTotal): What do we call it?

//Parameters (double price): What "ingredients" does the method need to do its job?

// This is the "Recipe"
//double CalculateTotal(double price)
//{
//    double tax = price * 0.15;
//    double finalPrice = price + tax;

//    return finalPrice; // This "returns" the answer to whoever called it
//}

//double myItem = 100.00;

//// We call the method here
//double total = CalculateTotal(myItem);

//Console.WriteLine($"The total price with tax is: {total}");
// Output: The total price with tax is: 115

//using System.Runtime.Intrinsics.X86;
//using System.Xml.Linq;

//try writing that GetFullName method.

//The Goal:

//Create a method that takes string firstName and string lastName.

//Use it to print a full name to the console.

// 1. The Method (The Recipe)
//string GetFullName(string first, string last)
//{
//    // This combines the two strings with a space in between
//    return $"{first} {last}";
//}

//// 2. Using it (The Call)
//string teacher = GetFullName("Gemini", "AI");
//Console.WriteLine(teacher);

// Output: Gemini AI

//The Project: "The Capital City Quiz"
//We will create a method called CheckAnswer. This method will take the user's guess
//and the correct answer, then return true if they match.

// --- The Main Program Logic ---
//using System.ComponentModel;

//int score = 0;

//Console.WriteLine("Welcome to the Geography Quiz!");

//// Question 1
//Console.Write("What is the capital of France? ");
//string response1 = Console.ReadLine() ?? "";
//if (CheckAnswer(response1, "Paris"))
//{
//    Console.WriteLine("Correct! +1 Point");
//    score++;
//}
//else Console.WriteLine("Wrong! The answer was Paris.");

//// Question 2
//Console.Write("What is the capital of Japan? ");
//string response2 = Console.ReadLine() ?? "";
//if (CheckAnswer(response2, "Tokyo"))
//{
//    Console.WriteLine("Correct! +1 Point");
//    score++;
//}
//else Console.WriteLine("Wrong! The answer was Tokyo.");

//Console.WriteLine($"\nFinal Score: {score}/2");

//// --- The Method (The "Engine" of the project) ---
//bool CheckAnswer(string userGuess, string correctAnswer)
//{
//    // .Trim() removes accidental spaces, .ToLower() makes it case-insensitive
//    return userGuess.Trim().ToLower() == correctAnswer.ToLower();
//}

//Your "Project Level" Task
//Can you add a 3rd question to this quiz?

//The Challenge: Write a method called GetGrade that takes the int score and
//returns a string (like "Excellent" if the score is 3, or "Keep Trying" if it's lower).

//How would that GetGrade method look?

using System;
using System.Collections.Generic;

// --- 1. SETUP ---
int score = 0;
Console.WriteLine("Welcome to the Ultimate Geography Quiz!");
Console.WriteLine("---------------------------------------");

// --- 2. THE QUESTIONS ---
// We use our 'AskQuestion' method to keep the main flow clean
if (AskQuestion("What is the capital of France?", "Paris")) score++;
if (AskQuestion("What is the capital of Japan?", "Tokyo")) score++;
if (AskQuestion("What is the capital of Germany?", "Berlin")) score++;

// --- 3. THE RESULTS ---
Console.WriteLine("\n---------------------------------------");
Console.WriteLine($"Quiz Finished! Your Score: {score}/3");

// Call our 'GetGrade' method to get a custom message
string finalMessage = GetGrade(score);
Console.WriteLine($"Result: {finalMessage}");


// --- 4. THE METHODS (The "Recipes") ---

// This method handles the logic of asking, reading, and checking
bool AskQuestion(string question, string correctAnswer)
{
    Console.Write($"\n{question} ");
    string userGuess = Console.ReadLine() ?? "";

    if (CheckAnswer(userGuess, correctAnswer))
    {
        Console.WriteLine("CORRECT! +1 Point");
        return true;
    }
    else
    {
        Console.WriteLine($"WRONG! The correct answer was: {correctAnswer}");
        return false;
    }
}

// This method only handles the string comparison
bool CheckAnswer(string guess, string answer)
    => guess.Trim().ToLower() == answer.ToLower();

// This method returns a string based on the final score
string GetGrade(int finalScore) => finalScore switch
{
    3 => "Excellent! You are a Geography Master!",
    2 => "Good job! You know your capitals.",
    1 => "Not bad, but room for improvement.",
    _ => "Keep studying! Try again."
};