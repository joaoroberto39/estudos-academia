using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleintegração.Model
{
    class account
    {
        public string TableName = "account";

        public IOrganizationService Service { get; set; }

        public account(IOrganizationService service)
        {
            this.Service = service;
        } 
        public void CreateAccount()
        {

           
            Entity account = new Entity(this.TableName);
            account["sy_cnpj"] = "15.226.698/0001-35";
            account["name"] = "Jerry Ritter";
            account["sy_tipodaconta"] = new OptionSetValue(100000000);
            account["sy_totaldeoportunidades"] = 1;
            account["sy_valortotaldeoportunidades"] = new Money(5000);
            account["primarycontactid"] = new EntityReference("contact", new Guid("f9bf4031-e526-ec11-b6e6-002248372d93"));
            Guid accountId = this.Service.Create(account);

            Console.WriteLine($"https://org455431bf.crm2.dynamics.com/main.aspx?appid=d81f9f2a-6125-ec11-b6e6-0022483725a9&pagetype=entityrecord&etn=account&id={accountId}");
            Console.ReadKey();
        }

        public void UpdateAccount()
        {
            Entity account = new Entity(this.TableName);
            account.Id = new Guid("f9bf4031-e526-ec11-b6e6-002248372d93");
            account["sy_cnpj"] = "57.845.278/0001-87";
            this.service.Update(account);


        }
    }
}
