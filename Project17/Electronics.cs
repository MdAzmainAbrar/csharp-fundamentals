//Derived Classes(Inheritance & Polymorphism)
//Now we create specialized items. Inheritance allows Electronics to get all the features of InventoryItem for free, while Polymorphism allows us to change how DisplayDetails works for this specific type.

using System;
using System.Collections.Generic;
using System.Text;

namespace Project17
{
    public class Electronics : InventoryItem
    {
        public int WarrantyMonths { get; set; }

        public Electronics(string name, double price, int warranty)
            : base(name, price) // Passing data to the parent constructor
        {
            WarrantyMonths = warranty;
        }

        // Overriding the base method
        public override void DisplayDetails()
        {
            Console.WriteLine($"[Electronics] {Name} | Price: {Price:C} | Warranty: {WarrantyMonths} months");
        }
    }
}
