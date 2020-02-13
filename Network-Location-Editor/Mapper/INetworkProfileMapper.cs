using NetworkLocationEditor.Entity;
using System.Collections.Generic;

namespace NetworkLocationEditor.Mapper
{
    interface INetworkProfileMapper
    {

        /// <summary>
        /// 列出所有NetworkProfile
        /// </summary>
        /// <returns>所有NetworkProfile</returns>
        List<NetworkProfile> List();

        /// <summary>
        /// 根据ID删除指定NetworkProfile
        /// </summary>
        /// <param name="id">ID</param>
        void Remove(string id);

    }
}
