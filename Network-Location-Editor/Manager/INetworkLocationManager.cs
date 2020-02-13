using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkLocationEditor.Entity;

namespace NetworkLocationEditor.Manager
{
    interface INetworkLocationManager
    {

        /// <summary>
        /// 列出所有NetworkLocation
        /// </summary>
        /// <returns>所有NetworkLocation</returns>
        List<NetworkLocation> List();

    }
}
