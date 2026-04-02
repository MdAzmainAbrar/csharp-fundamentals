// This is a simple C# console application that prompts the user for their name and then greets them.

Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine(); //the reutn data type of Console.ReadLine() is string,
                                  //so we can directly assign it to a string variable
Console.WriteLine($"Hello, {name}! Welcome to C# programming.");

Console.WriteLine("whats your age? : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Hello, {name}! Welcome to C# programming at the {age} years of age");

