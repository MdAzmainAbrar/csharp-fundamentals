using System;
using System.Collections.Generic;
using System.Text;

namespace Project12
{
    public interface ICourseActions
    {
        //defines the method the class must implement, but does not provide any implementation for the method
        //interface methods are public and abstract (means it has no body{it has a method signature only})
        //by default, so you do not need to specify the access modifier
        public void StartCourse();
        public void StopCourse();
    }
}
