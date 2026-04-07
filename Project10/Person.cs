using System;
using System.Collections.Generic;
using System.Text;

namespace Project10
{
    internal class Person : Object // all classes in C# implicitly inherit from the Object class,
                                   // which is the base class for all types in C#.
    {
        //classes have members, which are instance fields(data), properties, methods, and events
        //fields are variables that belong to a class
        //properties are like fields but with get and set accessors
        //methods are functions that belong to a class
        //events are notifications that a class can send to signal that something has happened
        //access modifiers control the visibility of class members (public, private, protected, internal)


        //its all about instance fields, methods are just functions that operate on those fields
        private string? _firstName; //a lot of time your instance fields are marked with an underscore
                                    //to indicate that they are private fields, this is a common convention in C#

        //Data hiding means your fields are private and can only be accessed through public methods
        //(getters and setters). This allows you to control how the data is accessed and
        //modified, and it helps to prevent bugs and maintain the integrity of your data.

        // all instance fields have default values when an object is created
        // strings are empty
        // integers are 0
        // booleans are false
        // floating point numbers are 0.0
        private string? _lastName; //opposite of a instance field is a static field, which belongs to the class
                                   //itself rather than any instance of the class. It is a shared piece of data
                                   //that all instances of the class can access and modify.
                                   // Accesor and Mutator Methods (Getters and Setters)
                                   //Constructor - Method that has a same name as the class, no return data type
                                   //used to initialized the object with other than the default values
                                   //Constructor is a mutated method for multiple instance fields,
                                   //it accepts parameters for each field and assigns them to the fields.
                                   //in simple words, it is a method that is called when an object is
                                   //created and it is used to initialize the object with specific values.
     // Create an age instance field, with accessor and mutator methods
     //add age to the constructor and ToString methods
        private int? _age;

        public Person(string fn, string ln, int? age) // two parameter constructor
        {
            _firstName = fn;
            _lastName = ln;
            _age = age;
        }

        public Person() //default constructor
        {

        }
        // accesor method
        public string GetFirstName()
        {
            return _firstName;
        }
        public string GetLastName()
        {
            return _lastName;
        }

        //Mutator method
        public void SetFirstName(string firstName) //mutator accepts one parameter, which is the new value for the field.
                                                   //It then assigns that value to the field.
        {
            _firstName = firstName; //notice that mutators assigns the instance field to the parameter,
                                    //not the other way around. This is a common convention in C#.
        }
        public int CalcDaysOld()
        {
            return _age.GetValueOrDefault() * 365; // GetValueOrDefault is a method that returns the value of the nullable type if it has a value, or the default value if it does not have a value. In this case, it will return 0 if _age is null.
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
        //Tostring method is a accessor for multiple instance fields, it returns a string representation
        //of the object that includes the values of the instance fields.
        override public string ToString() // ToString is a method that is inherited from the Object class,
                                          // it returns a string representation of the object. it is not very useful in
                                          // this case because it will just return the class name, but you can override
                                          // it to return something more useful.
                                          // The "override" keyword is used to indicate that we are
                                          // overriding a method that is inherited from the base class (Object in this case).
        {
            return $"The Person's name is : {_firstName} {_lastName} and is {_age} years old and {CalcDaysOld()} days old";
        }

        
    }
}
