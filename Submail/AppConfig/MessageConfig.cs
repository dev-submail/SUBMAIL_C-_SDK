﻿namespace Submail.AppConfig
{
    public class MessageConfig : IAppConfig
    {
        public MessageConfig(string appId, string appKey, SignType signType = SignType.normal)
        {
            _appId = appId;
            _appKey = appKey;
            _signType = signType;
        }

        private string _appId;
        public string AppId
        {
            get
            {
                return _appId;
            }
            set
            {
                _appId = value;
            }
        }

        private string _appKey;
        public string AppKey
        {
            get
            {
                return _appKey;
            }
            set
            {
                _appKey = value;
            }
        }

        private SignType _signType;
        public SignType SignType
        {
            get
            {
                return _signType;
            }
            set
            {
                _signType = value;
            }
        }
    }
}
