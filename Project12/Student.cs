using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Project12
{
    //Higher up the chain you are the more generic you are further down the inhritance hierarchy you are the more specific you
    //are, so a person is more generic than a student, because a student is a type of person,
    //but a person is not necessarily a student.

    //example - animal>>dog>>poodle, so animal is the most generic,
    //dog is more specific than animal but more generic than poodle,
    //and poodle is the most specific.
    public class Student : Person, ICourseActions //single inheritance, meaning you can only inherit from one parent class,
                                  //but you can implement multiple interfaces

                                  // an interface is a contract that defines a set of methods and properties
                                  // that a class must implement,
                                  // but it does not provide any implementation for those methods and properties.

                                  //interface forces behavior, while inheritance is more about code reuse, so you can use inheritance
                                  //to reuse code from a parent class, but you can also use it to create a new class that is a more
                                  //specific version of the parent class, while an interface is more about defining a contract that
                                  //a class must adhere to, so you can use an interface to define a set of methods and properties
                                  //that a class must implement, but it does not provide any implementation for those methods and properties. 
    {   //instance field
        private double _gpa;
        //student will inherate the non private feild and methods of a person
        public Student()
        { //this is the default constructor for the student class,
          //it is called when a student object is created without any parameters
        }

        public Student(string fn, string ln, int? age, double gpa) : base(fn, ln, age)
        //this keyword base says pass this three fields up to the parent constructor
        { //this is the constructor for the student class that takes three parameters,
          //it calls the base class constructor
          if (gpa < 0.0 || gpa > 4.0)
            {
                throw new ArgumentOutOfRangeException("gpa must be between 0.0 and 4.0");
            }
            _gpa = gpa;
        }

        public double GetGPA()
        {
            return _gpa;
        }

        public void StartCourse()
        {
            Console.WriteLine("Students turns on laptop, takes out notebook and pen. and is wide wake and attentive");
            throw new NotImplementedException();
        }

        public void StopCourse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "Their gpa is " + _gpa;
        }

    }
}
