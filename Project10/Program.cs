using Project10;

//create an instance of the Person class and set the first name using the mutator method,
//then get the first name using the accessor method and print it to the console.
Person firstPerson = new Person(); // default constructor - no arguments 
firstPerson.SetFirstName("Azmain");
firstPerson.SetLastName("Abrar");

Person secondPerson = new Person("You", "Know", 26); //2 param constructor
secondPerson.SetLastName("What?");

Console.WriteLine($"The first person's object name " +
    $"is {firstPerson.GetFirstName()} {firstPerson.GetLastName()} ");
//Console.WriteLine($"{secondPerson.ToString()}"); //or we can also write this line below same result
Console.WriteLine($"{secondPerson}");
//Console.WriteLine($"The first person's object name " +
//    $"is {secondPerson.GetFirstName()} {secondPerson.GetLastName()} ");

//Console.WriteLine(firstPerson.ToString()); // ToString is a method that is inherited from the Object class,
//                                           // it returns a string representation of the object. it is not very useful in
//                                           // this case because it will just return the class name, but you can override
//                                           // it to return something more useful.