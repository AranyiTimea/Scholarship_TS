 using System;
using System.Collections.Generic;

namespace ex_op_1_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities ut = new Utilities();

            List<Client> clients = new List<Client>()
            {
            new Client (){Id = 1, FirstName = "Ana", LastName = "Popescu", BirthYear=1984},
            new Client (){Id = 2, FirstName = "Mara", LastName = "Radu", BirthYear = 1974},
            new Client (){Id = 3, FirstName = "Marius", LastName = "Paun", BirthYear = 1954},
            new Client (){Id = 4, FirstName = "Flavia", LastName = "Dumitrescu", BirthYear = 1993},
            new Client (){Id = 5, FirstName = "Ioan", LastName = "Vasilescu", BirthYear = 1984},
            new Client (){Id = 6, FirstName = "Dana", LastName = "Constantinescu", BirthYear = 2005},
            new Client (){Id = 7, FirstName = "Ana", LastName = " Popescu ", BirthYear = 2000},
            new Client (){Id = 4, FirstName = "Flavia", LastName = " Dumitrescu ", BirthYear = 1993}
            };

            List<Client> newClients = new List<Client>()
            {
            new Client (){Id = 1, FirstName = "Ana", LastName = "Popescu", BirthYear=1984},
            new Client (){Id = 10, FirstName = "Mara", LastName = "Radu", BirthYear = 1974},
            new Client (){Id = 11, FirstName = "Marius", LastName = "Paun", BirthYear = 1954},
            new Client (){Id = 4, FirstName = "Flavia", LastName = "Dumitrescu", BirthYear = 1993},
            new Client (){Id = 13, FirstName = "Ioan", LastName = "Vasilescu", BirthYear = 1984}
            };

            Console.WriteLine("Clients Info: ");
            ut.DisplayClietnsDetails(clients);

            Console.WriteLine("\nClients over 40: ");
            ut.DisplayClientsOver40(clients);

            Console.WriteLine("\nMerged lists: ");
            ut.MergeLists(clients, newClients);

            Console.WriteLine("\nSorted descending by birthyear: ");
            ut.DescendentByBirthyear(clients);

            Console.WriteLine("\nSorted ascendent by name: ");
            ut.AscendentByName(clients);

            Console.WriteLine("\nMinor clients: ");
            ut.MinorsList(clients);

            Console.WriteLine("\nThere is duplicated data: {0}", ut.IsDuplicatedData(clients));

            Console.WriteLine("\nRemoved duplicated data: ");
            ut.RemoveDuplicatedData(clients);
        }
    }
}
