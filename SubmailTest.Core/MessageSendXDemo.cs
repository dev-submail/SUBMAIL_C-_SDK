using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class MessageSendXDemo
    {
        public void SendMessage()
        {
            IAppConfig appConfig = new MessageConfig("10051", "d13ff6b6ab46bd713d1d5ce6a0a0b78a");
            MessageXSend messageXSend = new MessageXSend(appConfig);
            messageXSend.AddTo("13756563150");
            messageXSend.SetProject("MApf82");
            messageXSend.AddVar("code", "a你好aaaa");
            string returnMessage = string.Empty;
            if (messageXSend.XSend(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }
        }
    }
}
