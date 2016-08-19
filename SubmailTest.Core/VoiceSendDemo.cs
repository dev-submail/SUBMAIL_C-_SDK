using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class VoiceSendDemo
    {
        public void VoiceVerify()
        {
            IAppConfig appConfig = new VoiceAppConfig("20139", "aeefd6d1170a354aa9282a04138c59ee");
            VoiceVerify voiceVerify = new VoiceVerify(appConfig);
            voiceVerify.AddTo("13756563150");
            // 此数字为语音播报的4位数字验证码
            voiceVerify.SetCode("1234");
            string returnMessage = string.Empty;
            if (voiceVerify.Verify(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }
        }
    }
}
