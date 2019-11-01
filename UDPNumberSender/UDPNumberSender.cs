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

            //Console.Write("State name: ");
            //String name = Console.ReadLine();

            //for (int i = 0; i < 5000; i++)
            //{
            //    Byte[] sendBytes = Encoding.ASCII.GetBytes(name + " " + number + " hello");

            //    udpClient.Send(sendBytes, sendBytes.Length); //, (RemoteEndPoint NOT in 1-1 communication);
            //    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
            //    //Client is now activated");

            //    string receivedData = Encoding.ASCII.GetString(receiveBytes);
            //    Console.WriteLine(receivedData);
            //    number++;

            //    Thread.Sleep(100);
            //}

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
