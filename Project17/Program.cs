//Scenario: You are building a system for a warehouse.

//using static System.Runtime.InteropServices.JavaScript.JSType;

//Create a base class for items.

//Ensure some data is protected from direct tampering.

//Create specific types of items (like Electronics) that calculate tax differently.

//Create a manager to track these items.

using Project17;

class Program
{
    static void Main(string[] args)
    {
        Warehouse myWarehouse = new Warehouse();

        // Adding different types of items
        myWarehouse.AddItem(new Electronics("Laptop", 1200.00, 24));
        myWarehouse.AddItem(new Electronics("Smartphone", 800.00, 12));

        // Showing how the system handles them
        myWarehouse.ShowAllItems();

        Console.ReadLine();
    }
}

//Encapsulation: We hid the _price field so it couldn't be set to a negative number by accident.

//Inheritance: Electronics inherited the Name and Price from InventoryItem.

//Polymorphism: The Warehouse treats everything as an InventoryItem, but when it calls DisplayDetails(), C# knows to use the Electronics version if that's what the object actually is.

//Abstraction: We used an abstract class because a "Product" is a concept, while a "Laptop" is a real thing you can sell.