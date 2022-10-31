#define ENABLE_IP_ADDRESS_TESTS
#define ENABLE_URI_TESTS
#define ENABLE_DNS_TESTS

namespace NetworkInvestigation.ConsoleApp
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            #if !ENABLE_IP_ADDRESS_TESTS
            
            IpAddressWrapper.CreateAndLogWithAddressFamily(new byte[] { 192, 168, 0, 1 });
            IpAddressWrapper.TryParseAndLog("192.168.0.2");
            IpAddressWrapper.LogStaticAddresses();
            IpAddressWrapper.CreateIpEndPointWithPortAndLog();
            
            #endif
            
            #if !ENABLE_URI_TESTS
            UriWrapper.CreateAndLogWithConstructor();
            UriWrapper.CreateAndLogWithAssigningValues();
            #endif

            #if ENABLE_DNS_TESTS
            await DnsWrapper.GetHostAddressesAndLog("google.com");
            await DnsWrapper.GetHostEntryAndLog("google.com");
            #endif
            
            LocalSniffer.GetLocalAddress();
        }
    }
}