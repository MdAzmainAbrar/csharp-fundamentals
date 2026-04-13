//Records store our data and are used for data transfer between different parts of an application.
//They are immutable by default, which means once you create an instance of a record, you cannot change its properties.
//This immutability makes records ideal for representing data that should not be modified after creation,
//such as the details of a bank transaction or a user's profile information.

//records are a class by default and can have methods, properties and fields.
//But they have some special features that make them different from regular classes.

//How are they diferent from regular classes? 
//1. Value-based equality: Two instances of a record are considered equal if their properties are equal, regardless of whether they are the same object in memory. In contrast, classes use reference-based equality by default, where two instances are only considered equal if they reference the same object in memory.
//2. Concise syntax: Records have a more concise syntax for defining properties and constructors. You can define a record with a single line of code, while classes typically require more boilerplate code to define properties and constructors.
//3. Immutability: Records are immutable by default, which means that once you create an instance of a record, you cannot change its properties. In contrast, classes are mutable by default, which means that you can change the properties of an instance after it has been created.
//4. Built-in features: Records have built-in features such as deconstruction, with-expressions, and concise syntax for defining properties. These features make it easier to work with records and can help reduce boilerplate code in your application.
//5. Records are designed to be used as data containers, while classes can be used for a wider range of purposes, including representing complex objects with behavior and state. Records are ideal for representing simple data structures that do not require behavior, while classes are better suited for representing more complex objects with behavior and state.
//6. classes have no implementation of ToString(), Equals() and GetHashCode() methods,
//while records have a default implementation of these methods based on the properties of the record.
//This means that when you create a record, you automatically get a meaningful string representation,
//value-based equality, and a hash code based on the properties of the record, without having to write any additional code.
//In contrast, with classes, you would need to override these methods yourself if you want to achieve similar functionality.
//7. You can use a with expression to (copy records) create a new instance of a record with some properties modified,
//while keeping the original instance unchanged. This is not possible with classes, as they are mutable by default
//and do not have built-in support for with-expressions. With records, you can easily create new instances with
//modified properties without having to worry about unintended side effects on the original instance.
//8. records can inherit from other records, while classes can inherit from other classes.
//However, records cannot inherit from classes, and classes cannot inherit from records.
//This means that you can create a hierarchy of records, but you cannot mix records and classes in the same inheritance hierarchy.

using Project16;

//The Scenario: A Digital Guestbook
//Imagine you are building a system to track people visiting a building.
//You want to store their name and the company they work for.
//1. The Record Definition
//Instead of writing a 20-line class with a constructor and properties, you write this one line.
//This defines your data structure entirely.

using System;

// 1. Create a new Person (The Record)
var guest1 = new Person("Tony", "Stark", "Stark Industries");

// 2. Try to change a name? 
// guest1.FirstName = "Howard"; // ERROR! Records are 'init-only' by default. 

// 3. Create a "Copy" with one change (Non-destructive mutation)
// This creates a NEW person based on Tony, but changing the company.
var guest2 = guest1 with { Company = "Avengers HQ" };

// 4. Value Equality
// If we create another person with the exact same data...
var guest3 = new Person("Tony", "Stark", "Stark Industries");

// Even though guest1 and guest3 are different objects, they represent the same DATA.
if (guest1 == guest3)
{
    Console.WriteLine("These two records are identical!");
}

// 5. Easy Printing
// A 'class' would just print the name of the project. 
// A 'record' prints all the internal data automatically.
Console.WriteLine(guest1);
// Output: Person { FirstName = Tony, LastName = Stark, Company = Stark Industries }