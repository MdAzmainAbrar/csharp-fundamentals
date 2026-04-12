// Create an appplication that creates four classes: Page,Corner, Pancake, and Leaf
//create an interface called ITurnable that has a method called Turn()
//the 4 classes should implement that interface and a different implementation of the Turn() method
// in program.cs, create a List<ITurnable> and add an instance of each of the 4 classes to the list,
// write a single method  in program.cs that accepts a List<ITurnable> and calls the Turn() method on each item in the list,
// demonstrating polymorphism.

using Project14;

Leaf leaf = new Leaf();
Pancake pancake = new Pancake();
Corner corner = new Corner();   
Page page = new Page();

List<ITurnable> turnables = new List<ITurnable> { leaf, pancake, corner, page };

static void Turning(List<ITurnable> t)
{
    foreach (ITurnable turn in t)
    {
        Console.WriteLine(turn.Turn());
    }
}

Turning(turnables);