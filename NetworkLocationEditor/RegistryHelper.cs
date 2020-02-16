using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace NetworkLocationEditor
{
    public static class RegistryHelper
    {
        public static List<NTSignature> GetNetworkLocationList()
        {
            List<NTSignature> list = new List<NTSignature>();
            RegistryKey key = Registry.LocalMachine;
            string path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged";
            RegistryKey subKey = key.OpenSubKey(path, true);
            string[] signatures = subKey.GetSubKeyNames();
            path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
            subKey = key.OpenSubKey(path, true);
            string[] profiles = subKey.GetSubKeyNames();
            foreach (string s in signatures)
            {
                NTSignature nts = GetNTSignature(s);
                if (profiles.Contains(nts.ProfileGuid.ToString("B").ToUpper()))
                {
                    nts.Profiles = GetNTProfiles(nts.ProfileGuid);
                }
                list.Add(nts);
            }
            return list;
        }

        private static NTSignature GetNTSignature(string signatureName)
        {
            NTSignature nts = new NTSignature();
            RegistryKey key = Registry.LocalMachine;
            string path = string.Format(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged\{0}", signatureName);
            RegistryKey subKey = key.OpenSubKey(path, true);
            nts.SignatureName = signatureName;
            nts.GatewayMAC = BitConverter.ToString((byte[])subKey.GetValue("DefaultGatewayMac")).Replace("-", ":");
            nts.Description= subKey.GetValue("Description").ToString();
            nts.DnsSuffix = subKey.GetValue("DnsSuffix").ToString();
            nts.FirstNetwork = subKey.GetValue("FirstNetwork").ToString();
            string profileGuid = subKey.GetValue("ProfileGuid").ToString();
            nts.ProfileGuid = Guid.Parse(profileGuid);
            subKey.Close();
            return nts;
        }

        private static NTProfiles GetNTProfiles(Guid profileGuid)
        {
            NTProfiles ntp = new NTProfiles();
            string path = string.Format(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles\{0}", profileGuid.ToString("B").ToUpper());
            RegistryKey key = Registry.LocalMachine;
            RegistryKey subKey = key.OpenSubKey(path, true);
            ntp.ProfileGuid = profileGuid;
            ntp.ProfileName = subKey.GetValue("ProfileName").ToString();
            ntp.Category = Convert.ToInt32(subKey.GetValue("Category"));
            ntp.CategoryType = Convert.ToInt32(subKey.GetValue("CategoryType"));
            ntp.Managed = Convert.ToBoolean(subKey.GetValue("Managed"));
            ntp.NameType = subKey.GetValue("NameType").ToString();
            subKey.Close();
            return ntp;
        }

        public static void DelNTConfig(string signatureName, Guid profileGuid)
        {
            RegistryKey key = Registry.LocalMachine;
            string path = string.Format(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged\{0}", signatureName);
            key.DeleteSubKey(path, true);
            path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
            RegistryKey subKey = key.OpenSubKey(path, true);
            string[] profiles = subKey.GetSubKeyNames();
            string strProfileGuid = profileGuid.ToString("B").ToUpper();
            if (profiles.Contains(strProfileGuid))
            {
                path = string.Format(@"{0}\{1}", path, strProfileGuid);
                key.DeleteSubKey(path, true);
            }
        }

        public static void UpdateNTConfig(NTSignature nts)
        {

        }
    }
}
