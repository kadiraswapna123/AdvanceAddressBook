using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class RetriveContactsFromDatabase
    {
        public class AddressBook : DbContext
        {
            public AddressBook()
            { }
            public AddressBook(DbModel AddressBook)
                : base(AddressBook)
            {

            }
            public DbSet<Contact> contacts { get; set; }
            public DbSet<Address> Addresses { get; set; }
        }
    }
}
