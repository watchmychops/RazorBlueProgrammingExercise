using Microsoft.AspNetCore.HttpOverrides;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Task2IPFilter.Classes {
    internal class CIDRRange {
        public IPAddress Prefix { get; set; }
        public int PrefixLength { get; set; }
        public CIDRRange(IPAddress prefix, int prefixLength) {
            Prefix = prefix;
            PrefixLength = prefixLength;
        }

        public CIDRRange(string cidrRange) {
            if (!cidrRange.Contains("/")) {
                // throw exception not a valid address range
                throw new ArgumentException($"Unable to parse cidr range from string {cidrRange}");
            }
            // a.b.c.d/x
            var network = cidrRange.Split("/")[0];
            var length = int.Parse(cidrRange.Split("/")[1]);
            Prefix = IPAddress.Parse(network);
            PrefixLength = length;
        }

    }
}
