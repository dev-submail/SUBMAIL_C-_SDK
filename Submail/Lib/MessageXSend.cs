using Submail.AppConfig;

namespace Submail.Lib
{
    public class MessageXSend : SendBase
    {
        public const string ADDRESSBOOK = "addressbook";
        public const string TO = "to";
        public const string PROJECT = "project";
        public const string VARS = "vars";
	    public const string LINKS = "links";

        public MessageXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void AddTo(string address)
        {
            AddWithComma(TO, address);
        }

        public void AddAddressBook(string addressbook)
        {
            AddWithComma(ADDRESSBOOK, addressbook);
        }

        public void SetProject(string project)
        {
            _dataPair.Add(PROJECT, project);
        }

        public void AddVar(string key, string val)
        {
            AddWithJson(VARS, key, val);
        }

        public bool XSend(out string returnMessage)
        {
           return GetSender().XSend(_dataPair, out returnMessage);
        }
    }
}
