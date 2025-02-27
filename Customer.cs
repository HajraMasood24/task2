using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.UI;

namespace Challange1.BL
{
    internal class Customer
    {
       
            public string username; 
            public string password ;
            public string email;
            public string address;
            public string contactNumber;

            public Customer(string username, string password, string email, string address, string contactNumber)
            {
                username = this.username;
                password = this.password;
                email = this.email;
                address = this.address;
                contactNumber = this.contactNumber;
            }



        }
    }