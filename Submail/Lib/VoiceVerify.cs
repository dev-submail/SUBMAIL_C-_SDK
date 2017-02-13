using Submail.AppConfig;

namespace Submail.Lib
{
    public class VoiceVerify : SendBase
    {
        public const string TO = "to";
        public const string CODE = "code";

        public VoiceVerify(IAppConfig appConfig) : base(appConfig)
        {
        }

        public void AddTo(string address)
        {
            _dataPair.Add(TO, address);
        }

        public void SetCode(string code)
        {
            _dataPair.Add(CODE, code);
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public bool Verify (out string returnMessage)
        {
            return GetSender().VoiceVerify(_dataPair, out returnMessage);
        }
    }
}
