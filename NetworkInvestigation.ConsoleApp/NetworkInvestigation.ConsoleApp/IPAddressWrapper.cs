using System;
using System.Net;

namespace NetworkInvestigation.ConsoleApp;

public static class IpAddressWrapper
{
    public static void CreateAndLogWithAddressFamily(byte[] address)
    {
        var ipAddressFirst = new IPAddress(address);
        Console.WriteLine($"Created ip: {ipAddressFirst}. Family: {ipAddressFirst.AddressFamily}");
    }
    
    public static void TryParseAndLog(string address)
    {
        IPAddress.TryParse(address, out var ipAddressSecond);
        Console.WriteLine(ipAddressSecond);
    }

    public static void LogStaticAddresses()
    {
        Console.WriteLine($"Loopback: {IPAddress.Loopback}");
        Console.WriteLine($"Any: {IPAddress.Any}");
        Console.WriteLine($"Broadcast: {IPAddress.Broadcast}");
    }

    public static void CreateIpEndPointWithPortAndLog()
    {
        // First version
        
        /*
        IPAddress ip = IPAddress.Parse("192.168.0.1");
        IPEndPoint endpoint = new IPEndPoint(ip, 8080);
        Console.WriteLine(endpoint);
        */
        
        
        // Second version
        IPEndPoint.TryParse("127.0.0.1:8080", out IPEndPoint? endPoint);
        Console.WriteLine($"Full address: {endPoint}, Ip: {endPoint?.Address}, Port: {endPoint?.Port}, Family: {endPoint?.AddressFamily}");
    }
}