using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class AddressBookMailDemo
    {
        public void Subscribe()
        {
            IAppConfig mailConfig = new MailAppConfig("10050", "2be0927e1628e16e1ccdb6f5800caac9");
            AddressBookMail addressBookMail = new AddressBookMail(mailConfig);
            addressBookMail.SetAddress("leo12@submail.cn", "leo");
            addressBookMail.SetAddressBook("61RgC3");

            string outMessage = string.Empty;
            bool issuccess = addressBookMail.Subscribe(out outMessage);
            if (!issuccess)
            {
                Console.WriteLine(outMessage);
            }
        }

        public void UnSubscribe()
        {
            IAppConfig mailConfig = new MailAppConfig("10050", "2be0927e1628e16e1ccdb6f5800caac9");
            AddressBookMail addressBookMail = new AddressBookMail(mailConfig);
            addressBookMail.SetAddress("leo12@submail.cn", "leo");
            string outMessage = string.Empty;
            bool issuccess = addressBookMail.UnSubscribe(out outMessage);
            if (!issuccess)
            {
                Console.WriteLine(outMessage);
            }
        }
    }
}
