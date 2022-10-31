using System;

namespace NetworkInvestigation.ConsoleApp;

public static class UriWrapper
{
    private const string HttpsScheme = "https";
    private const int DefaultPort = 80;
    
    public static void CreateAndLogWithConstructor()
    {
        var uri = new UriBuilder(
            HttpsScheme, "example.first.com", DefaultPort, "/home/library");
        Console.WriteLine(uri);
    }

    public static void CreateAndLogWithAssigningValues()
    {
        var uri = new UriBuilder();
        uri.Scheme = HttpsScheme;
        uri.Host = "example.second.com";
        uri.Port = DefaultPort;
        uri.Path = "home";
        uri.Query = "name=Alexey&age=32";
        uri.Fragment = "base_user";
        
        Console.WriteLine(uri);
    }
}