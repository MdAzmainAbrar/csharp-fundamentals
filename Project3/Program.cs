using System.Linq;
int length;

// 1. Start an infinite loop that only breaks on valid input
while (true)
{
    Console.Write("How many times you want to run the code? : ");
    string input = Console.ReadLine();

    // 2. TryParse checks if it's a number; then we check if it's > 0
    if (int.TryParse(input, out length) && length > 0)
    {
        break; // Valid input! Exit the loop.
    }

    // 3. If we reach here, the input was invalid
    Console.WriteLine("Invalid input. Please enter a positive whole number.");
}

// Your existing FizzBuzz logic
foreach (int i in Enumerable.Range(1, length))
{
    string result = i switch
    {
        _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
        _ when i % 3 == 0 => "Fizz",
        _ when i % 5 == 0 => "Buzz",
        _ => i.ToString(),
    };

    Console.WriteLine(result);
}