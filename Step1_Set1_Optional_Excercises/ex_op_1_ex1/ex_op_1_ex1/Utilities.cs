using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_op_1_ex1
{
    class Utilities
    {
        public void DisplayClietnsDetails(List<Client> clients)
        {
            clients.ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }

        public void DisplayClientsOver40(List<Client> clients)
        {
            int currentYear = DateTime.Today.Year;
            clients.Where(x => currentYear - x.BirthYear > 40).ToList().ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }

        public void MergeLists(List<Client> clients, List<Client> newClients)
        {
            clients.Union(newClients).ToList().ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }

        public void DescendentByBirthyear(List<Client> clients)
        {
            clients.OrderByDescending(x => x.BirthYear).ToList().ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }

        public void AscendentByName(List<Client> clients)
        {
            clients.OrderBy(x => x.FirstName).ToList().ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }

        public void MinorsList(List<Client> clients)
        {
            int currentYear = DateTime.Today.Year;
            clients.Where(x => currentYear - x.BirthYear < 18).ToList().ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }

        public bool AreMinors(List<Client> clients)
        {
            int currentYear = DateTime.Today.Year;
            var minors = clients.Where(x => currentYear - x.BirthYear < 18).ToList();
            if (minors != null)
                return true;
            return false;
        }

        public bool IsDuplicatedData(List<Client> clients)
        {
            return clients.GroupBy(x => new { x.Id, x.FirstName, x.LastName, x.BirthYear })
                   .Where(x => x.Skip(1).Any()).Any();
        }

        public void RemoveDuplicatedData(List<Client> clients)
        {
            clients.Distinct().ToList().ForEach(x => { Console.WriteLine(x.FirstName + ' ' + x.LastName + '\t' + x.BirthYear); });
        }
    }
}
