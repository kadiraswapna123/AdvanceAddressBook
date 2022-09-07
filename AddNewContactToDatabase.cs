using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    public class AddNewContactToDatabase
    {
        create Table private tbl_Customer
            (

                CustomerId int IDENTITY(1,1) NOT NULL primary key,
                Name Varchar(20) NOT NULL,
                Address varchar(100) not null,    
                City Varchar(20) NOT NULL,
                Country Varchar(20) NOT NULL,
                Gender Varchar(6) NOT NULL,
                MobileNo varchar(15) NOT NULL,
                MailId varchar(20) NOT NULL  
      
            );  
    }
}
