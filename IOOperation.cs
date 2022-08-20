using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class IOOperation
    {
        private void GetUserDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    Console.WriteLine("ID :" + jObject["id"].ToString());
                    Console.WriteLine("Name :" + jObject["name"].ToString());

                    var address = jObject["address"];
                    Console.WriteLine("Street :" + address["street"].ToString());
                    Console.WriteLine("City :" + address["city"].ToString());
                    Console.WriteLine("Zipcode :" + address["zipcode"]);
                    JArray experiencesArrary = (JArray)jObject["experiences"];
                    if (experiencesArrary != null)
                    {
                        foreach (var item in experiencesArrary)
                        {
                            Console.WriteLine("company Id :" + item["companyid"]);
                            Console.WriteLine("company Name :" + item["companyname"].ToString());
                        }

                    }
                    Console.WriteLine("Phone Number :" + jObject["phoneNumber"].ToString());
                    Console.WriteLine("Role :" + jObject["role"].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
