using Microsoft.AspNetCore.HttpOverrides;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Task2IPFilter.Classes {
    internal class SingleAddress {
        public IPAddress Address { get; set; }

        public SingleAddress(IPAddress address) {
            Address = address;
        }
        public SingleAddress(string address) {
            Address = IPAddress.Parse(address);
        }
    }

}
