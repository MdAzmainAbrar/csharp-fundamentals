using System;
using System.Collections.Generic;
using System.Text;

namespace Project12
{
    internal class Book
    {
        //properties do the same thing as methods, but they are more concise and easier to read,
        //so they are often used to encapsulate data in a class.

        //private int _numPages;

        ////C# property syntax, it is a shorthand for a getter and setter method,
        ////it allows you to access the private field _numPages
        //public int NumPages
        //{
        //    get { return _numPages; }
        //    set { _numPages = value; }
        //}
        //private int _numPages2; 
        //private int _numPages3; 
        //private int _numPages4; 
        //private int _numPages5;

        //auto implemented properties, it is a shorthand for a property that does not have a backing field, 
        //it allows you to access the property directly without having to create a private field
        // i cannot use this when i need to do some validation or some other logic in the getter or setter,
        // but if i just need a simple property that does not require any additional logic, then this is a great way to do it.
        // meaning if i just need a simple property that does not require any additional logic, then this is a great way to do it.
        public int? NumPages { get; set; } = 200; //here 200 can be used as a default value for the property,
                                                 //so if we create a book object and do not set the NumPages
                                                 //property, it will default to 200.

                                                 //here we cannot use _Numpages because we are using an auto implemented property,
                                                 //which does not have a backing field, so we cannot use a private field to store
                                                 //the value of the property, instead we can just use the property itself to store
                                                 //the value, and we can access it directly without having to create a private field.
    }
}
