using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class MessageMultiXSendDemo
    {
        public void SendMultiMessage()
        {
            IAppConfig appConfig = new MessageConfig("10051", "d13ff6b6ab46bd713d1d5ce6a0a0b78a");
            MessageMultiXSend messageMultiSend = new MessageMultiXSend(appConfig);
            messageMultiSend.SetProject("MApf82");

            Dictionary<string, string> vars = new Dictionary<string, string>();
            vars.Add("code", "a你好aaaa");
            messageMultiSend.SetMulti(new List<MultiMessageItem>() {
                new MultiMessageItem() { to="13756563150"},
                new MultiMessageItem() { to="13240372516", vars = vars}
            });

            string returnMessage = string.Empty;
            if (messageMultiSend.MultiXSend(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }
        }
    }
}
