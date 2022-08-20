using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class AddMultipleContacts
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();

            Console.WriteLine("Please enter the person's name:");
            contact.Name = Console.ReadLine();

            Console.WriteLine("Please enter the person's e-mail address:");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Please enter the person's favorite color:");
            string tempColor = Console.ReadLine();
            contact.Favoritecolor = (System.Drawing.KnownColor)(Enum.Parse(typeof(System.Drawing.KnownColor), tempColor));
            try
            {

            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("This is an unknown color. Please enter a known color");
            }
        }
        class Color
        {
            enum clr
            // This is a list of colors for the user to pick from.
            {
                Red,
                Green,
                Blue,
                Yellow,
                Purple,
                Brown,
                Black,
                Crimson,
                White,
                Turqoise,
                Orange,
                Cyan,
                Pink,
                Gold,
                Silver,
                Bronze,
                Gray,
                Indigo,
                Rust
            }
        }
    }
}
