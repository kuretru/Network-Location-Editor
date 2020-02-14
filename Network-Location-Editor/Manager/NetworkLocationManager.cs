using NetworkLocationEditor.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkLocationEditor.Mapper;

namespace NetworkLocationEditor.Manager
{
    class NetworkLocationManager : INetworkLocationManager
    {

        private readonly INetworkProfileMapper networkProfileMapper;
        private readonly INetworkSignatureMapper networkSignatureMapper;

        public NetworkLocationManager()
        {
            networkProfileMapper = new NetworkProfileMapper();
            networkSignatureMapper = new NetworkSignatureMapper();
        }

        public List<NetworkLocation> List()
        {
            List<NetworkLocation> result = new List<NetworkLocation>();
            List<NetworkProfile> profiles = networkProfileMapper.List();
            Dictionary<string, NetworkProfile> profileDic = new Dictionary<string, NetworkProfile>();
            foreach(NetworkProfile profile in profiles)
            {
                profileDic.Add(profile.Id, profile);
            }
            List<NetworkSignature> signatures = networkSignatureMapper.List();
            foreach(NetworkSignature signature in signatures)
            {
                if(profileDic.ContainsKey(signature.ProfileGuid))
                {
                    result.Add(new NetworkLocation(profileDic[signature.ProfileGuid], signature));
                }
            }
            return result;
        }

        public void Remove(NetworkLocation record)
        {
            networkProfileMapper.Remove(record.ProfileId);
            networkSignatureMapper.Remove(record.SignatureId);
        }
    }
}
