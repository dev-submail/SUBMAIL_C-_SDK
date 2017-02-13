using Submail.AppConfig;

namespace Submail.Lib
{
    public class MailXSend : SendBase
    {
        public const string TO = "to";
        public const string  ADDRESSBOOK = "addressbook";
	    public const string FROM = "from";
	    public const string FROM_NAME = "from_name";
	    public const string REPLY = "reply";
	    public const string CC = "cc";
	    public const string BCC = "bcc";
	    public const string SUBJECT = "subject";
	    public const string PROJECT = "project";
	    public const string VARS = "vars";
	    public const string LINKS = "links";
	    public const string HEADERS = "headers";

        public MailXSend(IAppConfig appconfig) : base(appconfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Mail(_appConfig);
        }

        public void AddTo(string address, string name)
        {
            AddWithBracket(TO, name, address);
        }

        public void AddAddressBook(string addressbook)
        {
            AddWithComma(ADDRESSBOOK, addressbook);
        }

        public void SetSender(string sender, string name)
        {
            _dataPair.Add(FROM, sender);
            _dataPair.Add(FROM_NAME, name);
        }

        public void SetReply(string reply)
        {
            _dataPair.Add(REPLY, reply);
        }

        public void AddCc(string address, string name)
        {
            AddWithBracket(CC, name, address);
        }

        public void AddBcc(string address, string name)
        {
            AddWithBracket(BCC, name, address);
        }

        public void SetSubject(string subject)
        {
            _dataPair.Add(SUBJECT, subject);
        }

        public void SetProject(string project)
        {
            _dataPair.Add(PROJECT, project);
        }

        public void AddVar(string key, string val)
        {
            AddWithJson(VARS, key, val);
        }

        public void AddLink(string key, string val)
        {
            AddWithJson(LINKS, key, val);
        }

        public void AddHeaders(string key, string val)
        {
            AddWithJson(HEADERS, key, val);
        }

        public bool XSend(out string returnMessage)
        {
            return GetSender().XSend(_dataPair, out returnMessage);
        }
    }
}
