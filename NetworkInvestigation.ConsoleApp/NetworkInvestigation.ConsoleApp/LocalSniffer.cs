using System;
using System.Net;
using System.Net.Sockets;

namespace NetworkInvestigation.ConsoleApp;

public static class LocalSniffer
{
    public static void GetLocalAddress()
    {
        // check local connection
        if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
        {
            Console.WriteLine("Connection lost...");
            return;
        }
            
        // DNS server for the IP address associated with the hostname
        var host = Dns.GetHostEntry(Dns.GetHostName());

        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                Console.WriteLine(ip.ToString());
            }
        }        
    }
}