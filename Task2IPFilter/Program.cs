using Microsoft.AspNetCore.HttpOverrides;
using System;
using System.Collections.Generic;
using System.Net;
using Task2IPFilter.Classes;

namespace Task2IPFilter {
    internal class Program {

        // IP Address wrapper
        private static IPList ipList = new IPList();

        static void Main(string[] args) {
            ipList.Add(new AddressRange("192.168.1.0-192.168.1.255"));
            ipList.Add(new SingleAddress("192.168.87.1"));
            ipList.Add(new CIDRRange("192.168.1.10/24"));
            ipList.Add(new SingleAddress("192.163.35.23"));

            Console.WriteLine("Hello razorblue! Please enter an IP Address");
            var ipAddress = Console.ReadLine();
            Console.WriteLine(IsAddressInList(ipAddress));
        }

        private static bool IsAddressInList(string ipAddress) {

            // Additional verification needed for IP Address, out of bounds of this assignment I believe
            if (ipAddress == null) {
                throw new ArgumentException($"Can't parse {ipAddress} as an IP Address");
            }
            IPAddress address;
            var ip = IPAddress.TryParse(ipAddress, out address);
            return ipList.IpAddresses.Contains(address);
        }

    }
}
