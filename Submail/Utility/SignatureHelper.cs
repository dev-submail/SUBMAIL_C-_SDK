using Submail.AppConfig;
using System.Security.Cryptography;
using System.Text;

namespace Submail.Utility
{
    public class SignatureHelper
    {
        private IAppConfig _appConfig;
        public SignatureHelper(IAppConfig appConfig)
        {
            this._appConfig = appConfig;
        }

        /// <summary>
        /// Get signature based on sign type
        /// </summary>
        /// <param name="data">eg : key1=value1&key2=value2</param>
        /// <returns></returns>
        public string GetSignature(string data)
        {
            switch (_appConfig.SignType)
            {
                case SignType.normal:
                    {
                        return _appConfig.AppKey;
                    }
                case SignType.md5:
                    {
                        return GetMD5Signature(data);
                    }
                case SignType.sha1:
                    {
                        return GetSHA1Signature(data);
                    }
                default : 
                    return null;
            }
        }

        private string GetMD5Signature(string data)
        {
            string signStr = $"{_appConfig.AppId}{_appConfig.AppKey}{data}{_appConfig.AppId}{_appConfig.AppKey}";
            MD5 md5 = MD5.Create();
            byte[] fromData = Encoding.GetEncoding("utf-8").GetBytes(signStr);
            byte[] targetData = md5.ComputeHash(fromData);
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte b in targetData)
            {
                sBuilder.Append(b.ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private string GetSHA1Signature(string data)
        {
            string signStr = $"{_appConfig.AppId}{_appConfig.AppKey}{data}{_appConfig.AppId}{_appConfig.AppKey}";
            SHA1 sha1 = SHA1.Create();
            byte[] fromData = Encoding.GetEncoding("utf-8").GetBytes(signStr);
            byte[] targetData = sha1.ComputeHash(fromData);
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte b in targetData)
            {
                sBuilder.Append(b.ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
