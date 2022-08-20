using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class ReadEntries
    {
        if (fileExtension == ".json") 
{
    int count = 0;
    int count2 = 0;
    int inOrOut = 0;
    int nRecords=1; 
    JsonTextReader reader = new JsonTextReader(new StreamReader(txtLoaction.Text));
    string[] rawData = new string[5];
    while (reader.Read())
    {
        if (reader.Value != null)
            if (inOrOut == 1)
            {
                if (count == 6)
                {
                    nRecords++;
                    Array.Resize(ref rawData, nRecords);
                    //textBox1.Text += "\r\n";
                    count = 0;
                }
                rawData[count2] += reader.Value + ","; //+"\r\n"
                inOrOut = 0;
                count++;
                if (count2 == 500)
                {
                    MessageBox.Show(rawData[499]);
                }
            }
            else
            {
                inOrOut = 1;
            }
    } 
}
    }
}
