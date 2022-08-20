using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class NoOfContactPerson
    {
        public static void Main()
        {

            // Creating a List of integers
            List<int> firstlist = new List<int>();

            // adding elements in firstlist
            for (int i = 4; i < 10; i++)
            {
                firstlist.Add(i * 2);
            }

            // To get the number of
            // elements in the List
            Console.WriteLine(firstlist.Count);
        }
    }
}

