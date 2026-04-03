//Fizz buzz FizzBuzz



//Console.WriteLine("How many times you want to run the code? :");
//int length = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= length; i++)
//{
//    // This is a modern Switch Expression
//    string result = i switch
//    {
//        _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
//        _ when i % 3 == 0 => "Fizz",
//        _ when i % 5 == 0 => "Buzz",
//        _ => i.ToString() // The 'default' case 
//    };

//    Console.WriteLine(result);
//}



using System.Linq; // Required for Enumerable.Range
Console.WriteLine("How many times you want to run the code? :");
int length = Convert.ToInt32(Console.ReadLine());

// Enumerable.Range(1, length) creates a list: [1, 2, 3, ... length]

foreach (int i in Enumerable.Range(1, length))
{
    string result = i switch
    {
        _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
        _ when i % 3 == 0 => "Fizz",
        _ when i % 5 == 0 => "Buzz",
        _ => i.ToString(), // number format applied
    };

    Console.WriteLine(result);
}





//Imagine you want to display a "Status" tag based on the Current Salary in your app

//Console.WriteLine("Enter salary:");
//int salary = Convert.ToInt32(Console.ReadLine());
//string status = salary switch
//{
//    _ when salary < 20000 => "Entry Level",
//    >= 20000 and <= 50000 => "Mid Level",
//    > 50000 => "Senior Level",
//    _ => "Unknown"
//};
//Console.WriteLine(status);





