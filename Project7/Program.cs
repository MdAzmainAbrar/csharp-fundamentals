//using System.Runtime.InteropServices;

//Dictionary<int, string> students = new Dictionary<int, string>();

////Adding data into a dictionary
//students.Add(1, "Alice");
//students.Add(2, "Bob");
//students.Add(3, "Bop");
//students.Add(4, "Sob");

////Reading data out of a dictionary
//Console.WriteLine(students[1]);

//if (students.ContainsValue("Bop")){
//    Console.WriteLine("Bop is in the student list");


//Create a CLI application in c# to manage a contact list using a dictionary <string,string>. The application
//should allow the user to add, retrieve, update and delete contacts, where the key is the contact's name
//and the value is the phone number.
// Main Manu : display a menu with the following options:
// Add Contact, view Contact, Update Contact, Delete Contact, List all contact, Exit

//bool exit = false;
//Dictionary<string, string> phoneBook = new Dictionary<string, string>();

//phoneBook.Add("Alice", "123-456-7890");
//phoneBook.Add("Bob", "987-654-3210");
//phoneBook.Add("Charlie", "555-555-5555");
//phoneBook.Add("David", "111-222-3333");

//do
//{
//    Console.WriteLine("\n 1.Add Contact \n 2.view Contact \n 3.Update Contact \n 4.Delete Contact \n 5.List all contact \n 6.Exit ");
//    Console.Write("Enter choice: ");
//    string? choice = Console.ReadLine();
//    if (choice.Equals("6"))
//    {
//        exit = true;
//    }
//    else if(choice.Equals("1"))
//    {
//        Console.Write("Enter contact name: ");
//        string? name = Console.ReadLine();
//        Console.Write("Enter phone number: ");
//        string? phoneNumber = Console.ReadLine();
//        phoneBook.Add(name, phoneNumber);
//        Console.WriteLine("Contact added successfully.");
//    }
//    else if (choice.Equals("2"))
//    {
//        Console.Write("Enter contact name: ");
//        string? name = Console.ReadLine();
//        if (phoneBook.ContainsKey(name))
//        {
//            Console.WriteLine($"Phone number for {name}: {phoneBook[name]}");
//        }
//        else
//        {
//            Console.WriteLine("Contact not found.");
//        }
//    }
//    else if (choice.Equals("3"))
//    {
//        Console.Write("Enter contact name: ");
//        string? name = Console.ReadLine();
//        if (phoneBook.ContainsKey(name))
//        {
//            Console.Write("Enter new phone number: ");
//            string? newPhoneNumber = Console.ReadLine();
//            phoneBook[name] = newPhoneNumber;
//            Console.WriteLine("Contact updated successfully.");
//        }
//        else
//        {
//            Console.WriteLine("Contact not found.");
//        }
//    }
//    else if (choice.Equals("4"))
//    {
//        Console.Write("Enter contact name: ");
//        string? name = Console.ReadLine();
//        if (phoneBook.ContainsKey(name))
//        {
//            phoneBook.Remove(name);
//            Console.WriteLine("Contact deleted successfully.");
//        }
//        else
//        {
//            Console.WriteLine("Contact not found.");
//        }
//    }
//    else if (choice.Equals("5"))
//    {
//        Console.WriteLine("\nContact List:");
//        foreach (var contact in phoneBook)
//        {
//            Console.WriteLine($"{contact.Key}: {contact.Value}");
//        }
//    }
//} while (exit== false);




//Create a CLI application in c# to manage a contact list using a dictionary <string,string>. The application
//should allow the user to add, retrieve, update and delete contacts, where the key is the contact's name
//and the value is the phone number.
// Main Manu : display a menu with the following options:
// Add Contact, view Contact, Update Contact, Delete Contact, List all contact, Exit



using System;
using System.Collections.Generic;

// Modern C# Features: Target-typed new, Switch Expressions, Lambda Actions
Dictionary<string, string> phoneBook = new()
{
    ["Alice"] = "123-456-7890",
    ["Bob"] = "987-654-3210"
};

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("\n1.Add | 2.View | 3.Update | 4.Delete | 5.List | 6.Exit");
    Console.Write("Choice: ");
    string choice = Console.ReadLine() ?? "";

    // The Switch Expression: Concise, readable, and no 'break' keywords needed.
    Action operation = choice switch
    {
        "1" => () => AddContact(phoneBook),
        "2" => () => ViewContact(phoneBook),
        "3" => () => UpdateContact(phoneBook),
        "4" => () => DeleteContact(phoneBook),
        "5" => () => ListContacts(phoneBook),
        "6" => () => isRunning = false,
        _ => () => Console.WriteLine("Invalid selection.") // The default case
    };

    operation(); // Execute the chosen action
}

// Local functions for the logic
void AddContact(Dictionary<string, string> book)
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";
    Console.Write("Number: ");
    string number = Console.ReadLine() ?? "";

    if (!book.TryAdd(name, number)) Console.WriteLine("Already exists.");
    else Console.WriteLine("Added.");
}

void ViewContact(Dictionary<string, string> book)
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine(book.TryGetValue(name, out var num) ? $"Number: {num}" : "Not found.");
}

void UpdateContact(Dictionary<string, string> book)
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";
    if (book.ContainsKey(name))
    {
        Console.Write("New Number: ");
        book[name] = Console.ReadLine() ?? "";
        Console.WriteLine("Updated.");
    }
    else Console.WriteLine("Not found.");
}

void DeleteContact(Dictionary<string, string> book)
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine(book.Remove(name) ? "Deleted." : "Not found.");
}

void ListContacts(Dictionary<string, string> book)
{
    Console.WriteLine("\n--- Contacts ---");
    foreach (var (name, number) in book) Console.WriteLine($"{name,-10}: {number}");
}