using System;

namespace NetworkLocationEditor.Entity
{
    class NetworkLocation
    {

        private string signatureId;
        private string profileId;
        private string name; // 名称
        private string description; // 描述
        private string defaultGatewayMac; // 默认网关地址
        private string dnsSuffix; // 域名后缀
        private int category; // 网络类别
        private DateTime dateCreated; // 创建时间
        private DateTime dateLastConnected; // 上一次连接时间

        public NetworkLocation(NetworkProfile profile, NetworkSignature signature)
        {
            this.signatureId = signature.Id;
            this.profileId = profile.Id;
            this.name = profile.ProfileName;
            this.description = profile.Description;
            this.defaultGatewayMac = signature.DefaultGatewayMac;
            this.dnsSuffix = signature.DnsSuffix;
            this.category = profile.Category;
            this.dateCreated = profile.DateCreated;
            this.dateLastConnected = profile.DateLastConnected;
        }

        public string SignatureId { get => signatureId; set => signatureId = value; }
        public string ProfileId { get => profileId; set => profileId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string DefaultGatewayMac { get => defaultGatewayMac; set => defaultGatewayMac = value; }
        public string DnsSuffix { get => dnsSuffix; set => dnsSuffix = value; }
        public string Category { get => category == 1 ? "专用网络" : "公用网络"; set => category = value == "专用网络" ? 1 : 0; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime DateLastConnected { get => dateLastConnected; set => dateLastConnected = value; }
    }
}
