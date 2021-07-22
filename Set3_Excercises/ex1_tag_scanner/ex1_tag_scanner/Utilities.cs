using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_tag_scanner
{
    class Utilities
    {
        public List<Employee> AddEmployees()
        {
            return new List<Employee> {
                new Employee(1, "Employee1", true),
                new Employee(2, "Employee2", true),
                new Employee(3, "Employee3", false),
                new Employee(4, "Employee4", true),
                new Employee(5, "Employee5", true),
                new Employee(6, "Employee6", false),
                new Employee(7, "Employee7", true),
                new Employee(8, "Employee8", true),
                new Employee(9, "Employee9", false)
            };
        }
    }
}
