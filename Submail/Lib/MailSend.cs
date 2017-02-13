using Submail.AppConfig;
using System.IO;

namespace Submail.Lib
{
    public class MailSend : SendBase
    {
        private const string TO = "to";
        private const string ADDRESSBOOK = "addressbook";
        private const string FROM = "from";
        private const string FROM_NAME = "from_name";
        private const string REPLY = "reply";
        private const string CC = "cc";
        private const string BCC = "bcc";
        private const string SUBJECT = "subject";
        private const string TEXT = "text";
        private const string HTML = "html";
        private const string VARS = "vars";
        private const string LINKS = "links";
        private const string ATTACHMENTS = "attachments";
        private const string HEADERS = "headers";

        public MailSend(IAppConfig appConfig) : base(appConfig)
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

        public void AddAddressBook(string addAddressBook)
        {
            AddWithComma(ADDRESSBOOK, addAddressBook);
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

        public void SetText(string text)
        {
            _dataPair.Add(TEXT, text);
        }

        public void SetHtml(string html)
        {
            _dataPair.Add(HTML, html);
        }

        public void AddVar(string key, string val)
        {
            AddWithJson(VARS, key, val);
        }

        public void AddLink(string key, string val)
        {
            AddWithJson(LINKS, key, val);
        }

        public void AddAttachment(string file)
        {
            AddWithIncrease(ATTACHMENTS, new FileInfo(file));
        }

        public void AddHeaders(string key, string val)
        {
            AddWithJson(HEADERS, key, val);
        }

        public bool Send(out string returnMessage)
        {
            return GetSender().Send(_dataPair, out returnMessage);
        }
    }
}
