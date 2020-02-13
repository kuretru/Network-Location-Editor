using NetworkLocationEditor.Entity;
using System.Collections.Generic;

namespace NetworkLocationEditor.Mapper
{
    interface INetworkSignatureMapper
    {

        /// <summary>
        /// 列出所有NetworkSignature
        /// </summary>
        /// <returns>所有NetworkSignature</returns>
        List<NetworkSignature> List();

        /// <summary>
        /// 根据ID删除指定NetworkSignature
        /// </summary>
        /// <param name="id">ID</param>
        void Remove(string id);

    }
}
