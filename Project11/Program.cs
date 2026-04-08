// create a cart class that represents a shopping cart in an ecommerce application. The cart class should have the following
// instance fields: _cartId (string) _items (dictionary of <string,double> such as <"lolipoop",2.5> 
// The cart class should have the following methods to
// AddItems- adds an item to the cart,
// RemoveItem - remove items from the cart,
// GetTotal - returns the total cost of the items in the cart,

using Project11;

//Dictionary<string, double> items = new Dictionary<string, double>();
//items.Add("lolipoop", 2.5);
//items.Add("candy", 1.0);
//items.Add("soda", 1.5);

Cart cart1 = new Cart("12345");
cart1.AddItem("lolipoop", 2.5);
cart1.AddItem("candy", 1.0);
cart1.AddItem("soda", 1.5);

Console.WriteLine(cart1);
cart1.RemoveItem("candy");
Console.WriteLine(cart1);

Cart cart2 = new Cart("44444");
cart2.AddItem("chips", 3.0);
cart2.AddItem("soda", 1.5);
cart2.AddItem("candy", 1.0);
Console.WriteLine(cart2);

