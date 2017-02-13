namespace Submail.AppConfig
{
    public interface IAppConfig
    {
        string AppId { get; set; }

        string AppKey { get; set; }

        SignType SignType { get; set; }
    }

    public enum SignType
    {
        normal,
        md5,
        sha1
    }
}
