using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPNumberSender
{
    class UDPNumberSenderBroad
    {
        static void Main1(string[] args)
        {
            int number = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            UdpClient udpSender = new UdpClient();

            udpSender.EnableBroadcast = true;

            IPEndPoint remoteIpEndPoint = new IPEndPoint(ip, 9999);

            while (true)
            {
                
            }
        }
    }
}
