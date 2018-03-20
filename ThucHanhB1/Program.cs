using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ThucHanhBuoi1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //bai 1
            String strHostname = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostname);
            IPHostEntry iphost = Dns.GetHostEntry(strHostname);
            int nIp = 0;
            foreach (IPAddress ipaddress in iphost.AddressList)
            {
                Console.WriteLine("IP #" + ++nIp + ": " + ipaddress.ToString());
            }
            //bai 2
            Console.WriteLine("Nhap ten mien hoac nhap ip: ");
            string host = Console.ReadLine();
            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Ten Mien: ", e.HostName);
            foreach (string s in e.Aliases)
                Console.WriteLine("Bi danh: " + s);
            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("IP: " + i);
            
           
        }
    }
}
