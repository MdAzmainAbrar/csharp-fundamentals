using Project13;

Patient p1=new Patient();
FootballPlayer p2=new FootballPlayer();
Upholsterer p3=new Upholsterer();

Recovery(p1); //any class that implements the IRecoverable interface can be passed to the Recovery method,
              //because the Recovery method accepts an IRecoverable object as a parameter,
              //and all three classes (Patient, FootballPlayer, and Upholsterer) implement
              //the IRecoverable interface, so they can all be passed to the Recovery method without any issues.
Recovery(p2);
Recovery(p3);
void Recovery(IRecoverable recoverable) //this method accepts an IRecoverable object as a parameter, which means that
                                        //it can accept any object that implements the IRecoverable interface, this allows us
                                        //to use polymorphism to call the Recover method on any object that implements the
                                        //IRecoverable interface, without having to worry about the specific type of the object.

                                        //The rule here is that any class that implements the IRecoverable interface must provide
                                        //an implementation for the Recover method, so we can be sure that when we call the Recover
                                        //method on an IRecoverable object, it will work as expected, regardless of the specific
                                        //type of the object.
{
    Console.WriteLine(recoverable.Recover());
}

//polymorphism states that a methods behavior can be different based on the type of object that is passed to it,
//so when we call the Recovery method with different types of objects that implement the IRecoverable interface,
//we will get different behavior based on the specific implementation of the Recover method in each class.

Foo(p3); //any class that inherits from the Object class can be passed to the Foo method, because the Foo method accepts
         //an Object as a parameter, and all classes in C# implicitly inherit from the Object class, so they can all be
         //passed to the Foo method without any issues.
void Foo(Object o) //any child of the Object class can be passed to the Foo method, because the Foo method accepts
                   //an Object as a parameter,
                   //and all classes in C# implicitly inherit from the Object class,
                   //so they can all be passed to the Foo method without any issues.
{
    Console.WriteLine(o.ToString());
}

