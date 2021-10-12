using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleintegração
{
   public class ConectionFactory
    {
        public static IOrganizationService GetCrmService()
        {
            string connectionString =
              "AuthType=OAuth;" +
              "Username=admin@joroberto9.onmicrosoft.com;" +
              "Password=cjbrjojo8$;" +
              "Url=https://org455431bf.crm2.dynamics.com/;" +
              "AppId=d2aae020-be04-44b8-9601-99c6fdab2b2c;" +
              "RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;";

            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);

            return crmServiceClient.OrganizationWebProxyClient;
        }
    }
}
