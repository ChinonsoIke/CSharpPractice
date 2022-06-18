using System;
using static System.Console;
using System.Net;
using System.Net.NetworkInformation;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a valid url: ");
            var url= ReadLine();
            if(string.IsNullOrWhiteSpace(url)){
                url= "https://google.com/search/engine/?page=1";
            }

            var uri= new Uri(url);
            WriteLine($"URL: {url}");
            WriteLine($"Sheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"Host: {uri.Host}");
            WriteLine($"Path: {uri.AbsolutePath}");
            WriteLine($"Query: {uri.Query}");

            IPHostEntry entry= Dns.GetHostEntry(uri.Host);
            WriteLine($"{entry.HostName} has the following IP addresses:");
            foreach(IPAddress address in entry.AddressList){
                WriteLine(address);
            }

            try{
                var ping= new Ping();
                WriteLine($"Pinging server, please wait ...");
                PingReply reply= ping.Send(uri.Host);
                WriteLine($"{uri.Host} was pinged and replied: {reply.Status}");
                if(reply.Status == IPStatus.Success){
                    WriteLine("Reply from {0} took {1:N0}ms",
                        arg0: reply.Address, arg1: reply.RoundtripTime);
                }
            }catch(Exception e){
                WriteLine($"{e.GetType().ToString()} says {e.Message}");
            }
        }
    }
}
