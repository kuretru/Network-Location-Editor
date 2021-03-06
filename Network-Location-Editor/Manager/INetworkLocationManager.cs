﻿using Kuretru.NetworkLocationEditor.Entity;
using System.Collections.Generic;

namespace Kuretru.NetworkLocationEditor.Manager
{
    interface INetworkLocationManager
    {

        /// <summary>
        /// 列出所有NetworkLocation
        /// </summary>
        /// <returns>所有NetworkLocation</returns>
        List<NetworkLocation> List();

        /// <summary>
        /// 列出所有无效的NetworkLocation
        /// </summary>
        /// <returns>所有无效的NetworkLocation</returns>
        List<NetworkLocation> ListInvalid();

        /// <summary>
        /// 更新指定NetworkLocation
        /// </summary>
        /// <param name="record">指定NetworkLocation</param>
        void Update(NetworkLocation record);

        /// <summary>
        /// 删除指定NetworkLocation
        /// </summary>
        /// <param name="record">指定NetworkLocation</param>
        void Remove(NetworkLocation record);

    }
}
