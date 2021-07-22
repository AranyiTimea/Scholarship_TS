using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_tag_scanner
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, bool active)
        {
            ID = id;
            Name = name;
            Active = active;
        }
    }
}
