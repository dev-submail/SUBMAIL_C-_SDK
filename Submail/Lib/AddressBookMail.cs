using Submail.AppConfig;

namespace Submail.Lib
{
    public class AddressBookMail : SendBase
    {
        private const string ADDRESS = "address";
        private const string TARGET = "target";

        public AddressBookMail(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Mail(_appConfig);
        }

        public void SetAddress(string address, string name)
        {
            _dataPair.Add(ADDRESS, string.Format("{0}<{1}>", name, address));
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
