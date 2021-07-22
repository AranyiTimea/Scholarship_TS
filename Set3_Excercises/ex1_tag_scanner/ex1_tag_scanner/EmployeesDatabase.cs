using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_tag_scanner
{
    class EmployeesList
    {
        private List<Employee> employees;

        public EmployeesList()
        {
            Utilities ut = new Utilities();
            employees = ut.AddEmployees();  // TODO: citirea dintr-un .json file sau o baza de date
        }

        public bool IsEmployee(string name)
        {
            foreach (var employee in employees)
            {
                if (employee.Name == name && employee.Active)
                    return true;
            }
            return false;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public bool IsExEmployee(string name)
        {
            foreach (var employee in employees)
            {
                if (employee.Name == name && !employee.Active)
                    return true;
            }
            return false;
        }
    }
}
