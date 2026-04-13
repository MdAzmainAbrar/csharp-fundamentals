using System;
using System.Collections.Generic;
using System.Text;

namespace Project16
{
    //records aare immutable by default, which means once you create an instance of a record, you cannot change its properties.
    //when to use records:
    //1. When you want to create a simple data container that holds values and does not require behavior (methods).
    //2. When you want to take advantage of value-based equality, where two instances of a record are considered equal if their properties are equal.
    //3. When you want to use the built-in features of records, such as deconstruction, with-expressions, and concise syntax for defining properties.
    //4. When you want to create immutable data structures that can be easily shared and passed around in your application without worrying about unintended modifications.
    //5. When you want to use records for data transfer objects (DTOs) or for representing data in a functional programming style.
    //6. when you want to test for value equality rather than reference equality, which is the default for classes.
    //This means that two record instances with the same property values will be considered equal,
    //even if they are different objects in memory.
    //7.when you want to create immutable data objects that can be easily shared and passed around in your application
    //without worrying about unintended modifications. Records are designed to be immutable by default, which means
    //that once you create an instance of a record, you cannot change its properties. This makes them ideal for representing data
    //that should not be modified after creation, such as the details of a bank transaction or a user's profile information.
    //In C# 9.0 and later, you can define a record using the "record" keyword. Records can be defined in two ways:
    //positional records and non-positional records.
    //public record Person
    //{
    //    //override the Equals method to do a deep comparison of the PhoneNumbers array
    //    //no longer using the syntax of the primary constructer
    //    //you get rid of the set block and use a keyword init instead, which allows you to set the property value only during object
    //    //initialization (when creating a new instance of the record) and prevents modification of the property value after the object
    //    //has been created.

    //}

    public record Person(string FirstName, string LastName, string Company);


}
