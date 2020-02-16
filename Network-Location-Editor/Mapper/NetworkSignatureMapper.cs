using Microsoft.Win32;
using NetworkLocationEditor.Entity;
using System;
using System.Collections.Generic;

namespace NetworkLocationEditor.Mapper
{
    class NetworkSignatureMapper : INetworkSignatureMapper
    {

        private static readonly string PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged\";

        public List<NetworkSignature> List()
        {
            List<NetworkSignature> result = new List<NetworkSignature>();
            RegistryKey localMachine = Registry.LocalMachine;
            using (RegistryKey parent = localMachine.OpenSubKey(PATH))
            {
                string[] signatures = parent.GetSubKeyNames();
                foreach (string id in signatures)
                {
                    RegistryKey key = parent.OpenSubKey(id);
                    NetworkSignature signature = new NetworkSignature(id);
                    signature.DefaultGatewayMac = BitConverter.ToString((byte[])key.GetValue("DefaultGatewayMac")).Replace("-", ":");
                    signature.Description = (string)key.GetValue("Description");
                    signature.DnsSuffix = (string)key.GetValue("DnsSuffix");
                    signature.FirstNetwork = (string)key.GetValue("FirstNetwork");
                    signature.ProfileGuid = (string)key.GetValue("ProfileGuid");
                    signature.Source = (int)key.GetValue("Source");
                    key.Close();
                    result.Add(signature);
                }
            }
            return result;
        }

        public void Update(NetworkSignature record)
        {
            if (record == null || record.Id == null || record.FirstNetwork == null || record.FirstNetwork.Trim().Length == 0)
            {
                return;
            }
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey parent = localMachine.OpenSubKey(PATH);
            string[] profiles = parent.GetSubKeyNames();
            if (Array.Exists(profiles, element => element == record.Id))
            {
                using (RegistryKey profile = parent.OpenSubKey(record.Id, true))
                {
                    profile.SetValue("Description", record.Description);
                    profile.SetValue("FirstNetwork", record.FirstNetwork);
                }
            }
        }

        public void Remove(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return;
            }
            RegistryKey localMachine = Registry.LocalMachine;
            using (RegistryKey parent = localMachine.OpenSubKey(PATH, true))
            {
                string[] profiles = parent.GetSubKeyNames();
                if (Array.Exists(profiles, element => element == id))
                {
                    parent.DeleteSubKey(id);
                }
            }
        }

    }
}
