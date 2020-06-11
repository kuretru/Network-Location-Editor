using Kuretru.NetworkLocationEditor.Entity;
using System.Collections.Generic;

namespace Kuretru.NetworkLocationEditor.Mapper
{
    interface INetworkProfileMapper
    {

        /// <summary>
        /// 列出所有NetworkProfile
        /// </summary>
        /// <returns>所有NetworkProfile</returns>
        List<NetworkProfile> List();

        /// <summary>
        /// 更新指定Profile
        /// </summary>
        /// <param name="record">指定Profile</param>
        void Update(NetworkProfile record);

        /// <summary>
        /// 根据ID删除指定NetworkProfile
        /// </summary>
        /// <param name="id">ID</param>
        void Remove(string id);

    }
}
