using NetTools;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Task2IPFilter.Classes {
    internal class IPList {
        public List<IPAddress> IpAddresses { get; set; }

        public IPList() {
            IpAddresses = new List<IPAddress>();
        }

        public void Add(SingleAddress ipAddress) {
            IpAddresses.Add(ipAddress.Address);
        }

        public void Add(AddressRange addressRange) {

            var ipAddressRange = new IPAddressRange(addressRange.StartAddress, addressRange.EndAddress);

            foreach (IPAddress ipAddress in ipAddressRange) {
                IpAddresses.Add(ipAddress);
            }

        }
        public void Add(CIDRRange cidrRange) {
            var ipAddressRange = new IPAddressRange(cidrRange.Prefix, cidrRange.PrefixLength);
            foreach (IPAddress ipAddress in ipAddressRange) {
                IpAddresses.Add(ipAddress);
            }
        }
    }
}
