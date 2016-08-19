using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class AddressBookMessageDemo
    {
        public void Subscribe()
        {
            IAppConfig appConfig = new MessageConfig("10051", "d13ff6b6ab46bd713d1d5ce6a0a0b78a");
            AddressBookMessage addressBookMessage = new AddressBookMessage(appConfig);
            string returnMessage = string.Empty;
            addressBookMessage.SetAddress("13756563150");
            if (addressBookMessage.Subscribe(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }
        }

        public void UnSubscribe()
        {
            IAppConfig appConfig = new MessageConfig("10051", "d13ff6b6ab46bd713d1d5ce6a0a0b78a");
            AddressBookMessage addressBookMessage = new AddressBookMessage(appConfig);
            string returnMessage = string.Empty;
            addressBookMessage.SetAddress("13756563150");
            if (addressBookMessage.UnSubscribe(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }
        }
    }
}
