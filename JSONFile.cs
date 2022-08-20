using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class JSONFile
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Access Json values using Keys.>");

                String jsonString = new StreamReader("give <.json> file Path here").ReadToEnd();

                // use below syntax to access JSON file
                var jsonFile = Welcome.FromJson(jsonString);

                string FileName = jsonFile.File;
                long Lvl = jsonFile.Level;
                bool isTrue = jsonFile.CSharp;

                Console.WriteLine(FileName);//JSON
                Console.WriteLine(Lvl);//1
                Console.WriteLine(isTrue);//true
            }
        }
    }
}
