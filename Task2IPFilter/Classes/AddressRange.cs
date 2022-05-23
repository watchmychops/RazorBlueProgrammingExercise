using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Task2IPFilter.Classes {
    internal class AddressRange {
        public IPAddress StartAddress { get; set; }
        public IPAddress EndAddress { get; set; }

        public AddressRange(IPAddress startAddress, IPAddress endAddress) {
            StartAddress = startAddress;
            EndAddress = endAddress;
        }

        public AddressRange(string range) {
            if (!range.Contains("-")) {
                // throw exception not a valid address range
                throw new ArgumentException($"Unable to parse range from string {range}");
            }

            var startAddress = range.Split("-")[0];
            var endAddress = range.Split("-")[1];

            StartAddress = IPAddress.Parse(startAddress);
            EndAddress = IPAddress.Parse(endAddress);
        }

    }
}
