using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_tag_scanner
{
    class Scanner
    {
        private EmployeesList employees;
        private Tag currentTag;
        private List<Tag> history;
        private Security security;

        public Scanner()
        {
            employees = new EmployeesList();
            history = new List<Tag>();
            security = new Security();
        }

        public void ReadTag(Tag tag)
        {
            currentTag = tag;
            history.Add(currentTag);
        }

        public void EvaluateTag()
        {
            if (employees.IsEmployee(currentTag.Name))
            {
                ShowMessage("Welcome " + currentTag.Name);
                resetScanner();
            }
            else
            {
                NonEmployee();
            }
        }

        public void NonEmployee()
        {
            if (employees.IsExEmployee(currentTag.Name))
            {
                ShowMessage("You don't work here anymore.");
                handleNonEmployees(true);
            }
            else
            {
                ShowMessage("You don't work here.");
                security.StartWarningAlarm();
                handleNonEmployees(false);
            }
        }

        private void handleNonEmployees(bool exEmployee)
        {
            var timesTried = history.Count;
            if (timesTried >= 3)
            {
                if (history[timesTried - 1].Name == history[timesTried - 2].Name && history[timesTried - 2].Name == history[timesTried - 3].Name)
                {
                    if (!exEmployee)
                    {
                        security.StartFireAlarm();
                    }
                    security.SendMailToAdmin();
                    resetScanner();
                }
            }
        }

        public void resetScanner()
        {
            history.Clear();
            currentTag = null;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
