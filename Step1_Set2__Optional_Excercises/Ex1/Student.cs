using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_2_ex1
{
    class Student: Person
    {
        private int age;
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", this.Age);
        }
    }
}
