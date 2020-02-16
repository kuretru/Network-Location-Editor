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

        public NetworkLocation()
        {

        }

        public NetworkLocation(NetworkProfile profile, NetworkSignature signature)
        {
            signatureId = signature.Id;
            profileId = profile.Id;
            name = profile.ProfileName;
            description = profile.Description;
            defaultGatewayMac = signature.DefaultGatewayMac;
            dnsSuffix = signature.DnsSuffix;
            category = profile.Category;
            dateCreated = profile.DateCreated;
            dateLastConnected = profile.DateLastConnected;
        }

        public NetworkLocation Clone()
        {
            NetworkLocation result = new NetworkLocation
            {
                signatureId = signatureId,
                profileId = profileId,
                name = name,
                description = description,
                defaultGatewayMac = defaultGatewayMac,
                dnsSuffix = dnsSuffix,
                category = category,
                dateCreated = dateCreated,
                dateLastConnected = dateLastConnected
            };
            return result;
        }

        public string SignatureId { get => signatureId; set => signatureId = value; }
        public string ProfileId { get => profileId; set => profileId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string DefaultGatewayMac { get => defaultGatewayMac; set => defaultGatewayMac = value; }
        public string DnsSuffix { get => dnsSuffix; set => dnsSuffix = value; }
        public int Category { get => category; set => category = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime DateLastConnected { get => dateLastConnected; set => dateLastConnected = value; }
    }
}
