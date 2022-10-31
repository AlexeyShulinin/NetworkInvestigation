using System;
using System.Net;

namespace NetworkInvestigation.ConsoleApp.Extensions;

public static class IpAddressExtensions
{
    public static void Log(this IPAddress[] source)
    {
        foreach (var address in source)
        {
            Console.WriteLine(address);
        }
    }
}