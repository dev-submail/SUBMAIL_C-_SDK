using Submail.AppConfig;
using Submail.Lib;
using System;

namespace SubMailTest
{
    public class MailSendDemo
    {
        public void SendMail()
        {
            IAppConfig mailConfig = new MailAppConfig("10050", "2be0927e1628e16e1ccdb6f5800caac9", SignType.sha1);
            MailSend submail = new MailSend(mailConfig);
            submail.AddTo("vaezt@outlook.com", "leo");
            submail.AddCc("leo@submail.cn", "leo");
            submail.AddBcc("leo@submail.cn", "leo");
            submail.SetSender("leo@inside.submail.me", "leo");
            submail.SetReply("service@submail.cn");
            submail.SetSubject("发送历史与明细");
            submail.SetText("发送历史与明细");
            //submail.AddAttachment(@"C:\attachment.txt");

            string resultMessage = string.Empty;
            if (submail.Send(out resultMessage) == false)
            {
                Console.WriteLine(resultMessage);
            }
        }
    }
}
