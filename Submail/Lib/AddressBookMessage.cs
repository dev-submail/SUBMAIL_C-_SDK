using Submail.AppConfig;

namespace Submail.Lib
{
    public class AddressBookMessage : SendBase
    {
        private const string ADDRESS = "address";
        private const string TARGET = "target";

        public AddressBookMessage(IAppConfig appConfig) : base(appConfig)
        {
        }       

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetAddress(string address)
        {
            _dataPair.Add(ADDRESS, address);
        }

        public void SetAddressBook(string target)
        {
            _dataPair.Add(TARGET, target);
        }

        public bool Subscribe(out string returnMessage)
        {
            return GetSender().Subscribe(_dataPair, out returnMessage);
        }

        public bool UnSubscribe(out string returnMessage)
        {
            return GetSender().UnSubscribe(_dataPair, out returnMessage);
        }
    }
}
