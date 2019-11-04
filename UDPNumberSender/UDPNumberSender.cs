using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPNumberSender
{
    class UDPNumberSender
    {
        static void Main(string[] args)
        {
            int number = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1"); //
            UdpClient udpClient = new UdpClient("127.0.0.1", 9999);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 9999); //
            //udpClient.Connect(RemoteIpEndPoint); //

            while (true)
            {
                Console.WriteLine(number);
                Byte[] sendBytes = Encoding.ASCII.GetBytes("The number is: " + number);

                udpClient.Send(sendBytes, sendBytes.Length);
                number++;

                Thread.Sleep(100);
            }
        }
    }
}
