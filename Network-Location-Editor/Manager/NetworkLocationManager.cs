using Kuretru.NetworkLocationEditor.Entity;
using Kuretru.NetworkLocationEditor.Mapper;
using System.Collections.Generic;

namespace Kuretru.NetworkLocationEditor.Manager
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
            foreach (NetworkProfile profile in profiles)
            {
                profileDic.Add(profile.Id, profile);
            }
            List<NetworkSignature> signatures = networkSignatureMapper.List();
            foreach (NetworkSignature signature in signatures)
            {
                if (profileDic.ContainsKey(signature.ProfileGuid))
                {
                    result.Add(new NetworkLocation(profileDic[signature.ProfileGuid], signature));
                }
            }
            return result;
        }

        public List<NetworkLocation> ListInvalid()
        {
            List<NetworkProfile> profiles = networkProfileMapper.List();
            Dictionary<string, NetworkProfile> profileDic = new Dictionary<string, NetworkProfile>();
            foreach (NetworkProfile profile in profiles)
            {
                profileDic.Add(profile.Id, profile);
            }

            List<NetworkSignature> signatures = networkSignatureMapper.List();
            Dictionary<string, NetworkSignature> signatureDic = new Dictionary<string, NetworkSignature>();
            foreach (NetworkSignature signature in signatures)
            {
                signatureDic.Add(signature.Id, signature);
            }

            List<NetworkLocation> locations = List();
            foreach (NetworkLocation location in locations)
            {
                profileDic.Remove(location.ProfileId);
                signatureDic.Remove(location.SignatureId);
            }

            List<NetworkLocation> result = new List<NetworkLocation>();
            foreach (NetworkProfile profile in profileDic.Values)
            {
                result.Add(new NetworkLocation(profile, new NetworkSignature("")));
            }
            foreach (NetworkSignature signature in signatureDic.Values)
            {
                result.Add(new NetworkLocation(new NetworkProfile(""), signature));
            }
            return result;
        }

        public void Update(NetworkLocation record)
        {
            if (record == null || record.ProfileId == null || record.SignatureId == null)
            {
                return;
            }
            NetworkProfile profile = new NetworkProfile(record.ProfileId);
            NetworkSignature signature = new NetworkSignature(record.SignatureId);
            profile.Category = record.Category;
            profile.Description = signature.Description = record.Description;
            profile.ProfileName = signature.FirstNetwork = record.Name;
            networkProfileMapper.Update(profile);
            networkSignatureMapper.Update(signature);
        }

        public void Remove(NetworkLocation record)
        {
            if (record == null)
            {
                return;
            }
            if (record.ProfileId != null && record.ProfileId.Trim() != "")
            {
                networkProfileMapper.Remove(record.ProfileId);
            }
            if (record.SignatureId != null && record.SignatureId.Trim() != "")
            {
                networkSignatureMapper.Remove(record.SignatureId);
            }
        }

    }
}
