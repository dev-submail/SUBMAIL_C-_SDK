using Submail.AppConfig;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Submail.Lib
{
    public class MessageMultiXSend : SendBase
    {
        public const string PROJECT = "project";
        public const string MULTI = "multi";
      
        public MessageMultiXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetProject(string project)
        {
            _dataPair.Add(PROJECT, project);
        }

        public void SetMulti(List<MultiMessageItem> multiItems)
        {
            _dataPair.Add(MULTI, JsonConvert.SerializeObject(multiItems));
        }

        public bool MultiXSend(out string returnMessage)
        {
            return GetSender().MultiXSend(_dataPair, out returnMessage);
        }
    }

    public class MultiMessageItem
    {
        public MultiMessageItem()
        {
            vars = new Dictionary<string, string>();
        }

        public string to { get; set; }

        public Dictionary<string, string> vars { get; set; }
    }
}
