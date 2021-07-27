using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_2_ex1
{
    class Teacher: Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
