using System;

namespace NetworkLocationEditor.Entity
{
    class NetworkProfile
    {

        private string id;
        private int category; // 分类
        private int categoryType; // 分类类别
        private DateTime dateCreated; // 创建日期
        private DateTime dateLastConnected; // 上一次连接日期
        private string description; // 描述
        private int managed; // 未知
        private int nameType; // 未知
        private string profileName; //配置名称

        public NetworkProfile(string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public int Category { get => category; set => category = value; }
        public int CategoryType { get => categoryType; set => categoryType = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime DateLastConnected { get => dateLastConnected; set => dateLastConnected = value; }
        public string Description { get => description; set => description = value; }
        public int Managed { get => managed; set => managed = value; }
        public int NameType { get => nameType; set => nameType = value; }
        public string ProfileName { get => profileName; set => profileName = value; }

    }
}
