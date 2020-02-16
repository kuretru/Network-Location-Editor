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
        /// 更新指定Signature
        /// </summary>
        /// <param name="record">指定Signature</param>
        void Update(NetworkSignature record);

        /// <summary>
        /// 根据ID删除指定NetworkSignature
        /// </summary>
        /// <param name="id">ID</param>
        void Remove(string id);

    }
}
