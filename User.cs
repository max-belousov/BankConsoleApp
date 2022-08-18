using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    internal abstract class User
    {
        public string? Name { get; set; }

        public virtual void ChangeClient(Client client)
        {

        }

        public virtual void SeeClient(Client client)
        {

        }
    }
}
