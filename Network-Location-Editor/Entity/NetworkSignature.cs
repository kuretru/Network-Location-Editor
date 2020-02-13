using System;

namespace NetworkLocationEditor.Entity
{
    class NetworkSignature
    {

        private string id;
        private string defaultGatewayMac; // 默认网关MAC地址
        private string description; // 描述信息
        private string dnsSuffix; //DNS后缀
        private string firstNetwork; // 初始网络名称
        private string profileGuid;  // 链接的网络配置GUID
        private int source;  // 未知

        public NetworkSignature(string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public string DefaultGatewayMac { get => defaultGatewayMac; set => defaultGatewayMac = value; }
        public string Description { get => description; set => description = value; }
        public string DnsSuffix { get => dnsSuffix; set => dnsSuffix = value; }
        public string FirstNetwork { get => firstNetwork; set => firstNetwork = value; }
        public string ProfileGuid { get => profileGuid; set => profileGuid = value; }
        public int Source { get => source; set => source = value; }

    }
}
