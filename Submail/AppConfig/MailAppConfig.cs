namespace Submail.AppConfig
{
    public class MailAppConfig : IAppConfig
    {
        public MailAppConfig(string appId, string appKey, SignType signType = SignType.normal)
        {
            AppId = appId;
            AppKey = appKey;
            SignType = signType;
        }

        public string AppId { get; set; }

        public string AppKey { get; set; }

        public SignType SignType { get; set; }
    }
}
