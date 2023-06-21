using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Models
{
    public class CustomerAccount
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
 

        public CustomerAccount(string fullname, string emailaddress, string password)
        {
            FullName = fullname;
            EmailAddress = emailaddress;
            Password = password;
            Id = ++Id;
        }
    }
}
