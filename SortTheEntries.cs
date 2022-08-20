using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class SortTheEntries
    {
        private static void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);
        }
    }
}
