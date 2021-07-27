using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_2_ex1
{
    class Person
    {
        private int age;

        public int Age { get => age; set => age = value; }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Greeting()
        {
            Console.WriteLine("Hello");
        }
    }
}
