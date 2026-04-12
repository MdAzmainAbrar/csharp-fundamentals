//inheritance is reffered to as "is a" relationship
// you can inherit from one and only one parent class, but you can implement multiple interfaces

using Project12;

Student s1 = new Student("John", "Doe", 20, 3.5);

Console.WriteLine(s1);

Book b1 = new Book();
b1.NumPages = 300;
Console.WriteLine("The book has " + b1.NumPages + " pages.");