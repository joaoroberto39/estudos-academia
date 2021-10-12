using consoleintegração.Model;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleintegração
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrganizationService service = ConectionFactory.GetCrmService();
            account account = new account();
            account.UpdateAccount();
        }

  
    }
}
