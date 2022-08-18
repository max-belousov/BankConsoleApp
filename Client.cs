using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    internal class Client
    {
        public Client(int id, string firstName, string secondName, string thirdName, string passport, string phone)
        {
            Id  = id;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Passport = passport;
            Phone = phone;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }

    }
}
