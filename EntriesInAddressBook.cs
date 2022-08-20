using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class EntriesInAddressBook
    {
        public class Person
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string PostCode { get; set; }
            // etc..
        }

        public class AddressBook
        {
            public List<Person> People { get; set; }

            // asc: ascending or descending
            // column: the property to use when sorting
            //         (in my case either LastName or Postcode)
            public void Sort(bool asc, string column)
            {
                // What should I put here?
            }

            // etc...
        }
    }
}
