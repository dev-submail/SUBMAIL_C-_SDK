namespace SubMailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSendDemo mailSendDemo = new MailSendDemo();
            mailSendDemo.SendMail();

            // MessageSendXDemo messageSendXDemo = new MessageSendXDemo();
            // messageSendXDemo.SendMessage();

            // MessageMultiXSendDemo messageMultiXSendDemo = new MessageMultiXSendDemo();
            // messageMultiXSendDemo.SendMultiMessage();

            //VoiceSendDemo voiceSendDemo = new VoiceSendDemo();
            //voiceSendDemo.VoiceVerify();
        }
    }
}
