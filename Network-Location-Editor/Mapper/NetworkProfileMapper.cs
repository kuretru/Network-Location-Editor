using Microsoft.Win32;
using NetworkLocationEditor.Entity;
using NetworkLocationEditor.Util;
using System;
using System.Collections.Generic;

namespace NetworkLocationEditor.Mapper
{
    class NetworkProfileMapper : INetworkProfileMapper
    {

        private static readonly string PATH = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles\";

        public List<NetworkProfile> List()
        {
            List<NetworkProfile> result = new List<NetworkProfile>();
            RegistryKey localMachine = Registry.LocalMachine;
            using (RegistryKey parent = localMachine.OpenSubKey(PATH))
            {
                string[] profiles = parent.GetSubKeyNames();
                foreach (string id in profiles)
                {
                    RegistryKey key = parent.OpenSubKey(id);
                    NetworkProfile profile = new NetworkProfile(id);
                    profile.Category = (int)key.GetValue("Category");
                    if (key.GetValue("CategoryType") != null)
                    {
                        profile.CategoryType = (int)key.GetValue("CategoryType");
                    }
                    profile.DateCreated = BinDateConverter.Parse((byte[])key.GetValue("DateCreated"));
                    profile.DateLastConnected = BinDateConverter.Parse((byte[])key.GetValue("DateLastConnected"));
                    profile.Description = (string)key.GetValue("Description");
                    profile.Managed = (int)key.GetValue("Managed");
                    profile.NameType = (int)key.GetValue("NameType");
                    profile.ProfileName = (string)key.GetValue("ProfileName");
                    key.Close();
                    result.Add(profile);
                }
            }
            return result;
        }

        public void Update(NetworkProfile record)
        {
            if (record == null || record.Id == null || record.ProfileName == null || record.ProfileName.Trim().Length == 0)
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
                    profile.SetValue("Category", record.Category);
                    profile.SetValue("Description", record.Description);
                    profile.SetValue("ProfileName", record.ProfileName);
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
