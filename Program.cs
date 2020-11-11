using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
namespace dotnetBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Will Call GetActiveUdpListeners()");
            try{
            var listeners =IPGlobalProperties.GetIPGlobalProperties().GetActiveUdpListeners();
            }catch (Exception e){
                Console.WriteLine("Failed while calling GetActiveUdpListeners()");
                Console.WriteLine(e);
            }

        }
    }
}
