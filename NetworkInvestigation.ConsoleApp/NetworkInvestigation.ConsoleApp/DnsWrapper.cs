using System.Net;
using NetworkInvestigation.ConsoleApp.Extensions;

namespace NetworkInvestigation.ConsoleApp;

public static class DnsWrapper
{
    public static async Task GetHostAddressesAndLog(string hostName)
    {
        var hostAddresses = await Dns.GetHostAddressesAsync(hostName);
        hostAddresses.Log();
    }
    
    public static async Task GetHostEntryAndLog(string hostName)
    {
        var entry = await Dns.GetHostEntryAsync(hostName);
        Console.WriteLine($"HostName: {entry.HostName}");
        entry.AddressList.Log();
    }
}