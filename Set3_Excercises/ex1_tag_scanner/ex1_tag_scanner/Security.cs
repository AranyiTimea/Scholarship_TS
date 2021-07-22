using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_tag_scanner
{
    class Security
    {
        public void StartWarningAlarm()
        {
            Console.WriteLine("Warning Alram started");
        }

        public void SendMailToAdmin()
        {
            Console.WriteLine("Sent a mail to the admin.");
        }

        public void StartFireAlarm()
        {
            Console.WriteLine("Fire Alram started");
        }
    }
}
