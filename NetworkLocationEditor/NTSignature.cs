using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkLocationEditor
{
    public class NTSignature
    {
        private string _signatureName;
        private string _gatewayMAC;
        private string _description;
        private string _dnsSuffix;
        private string _firstNetwork;
        private Guid _profileGuid;
        public string SignatureName
        {
            get
            {
                return _signatureName;
            }

            set
            {
                _signatureName = value;
            }
        }
        public string GatewayMAC
        {
            get
            {
                return _gatewayMAC;
            }

            set
            {
                _gatewayMAC = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
        public string DnsSuffix
        {
            get
            {
                return _dnsSuffix;
            }

            set
            {
                _dnsSuffix = value;
            }
        }
        public string FirstNetwork
        {
            get
            {
                return _firstNetwork;
            }

            set
            {
                _firstNetwork = value;
            }
        }
        public Guid ProfileGuid
        {
            get
            {
                return _profileGuid;
            }

            set
            {
                _profileGuid = value;
            }
        }

        public NTProfiles Profiles;
        public NTSignature()
        {
            this.Profiles = new NTProfiles();
        }
    }
}
