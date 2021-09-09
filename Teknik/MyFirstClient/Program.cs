using System;
using System.IO;
using System.Net.Sockets;

namespace MyFirstClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Program");

            TcpClient socket = new TcpClient("localhost", 7);
            

            string message = Console.ReadLine();

            while (!message.Equals("end"))
            {
                NetworkStream ns = socket.GetStream();

                StreamWriter writer = new StreamWriter(ns);
                StreamReader reader = new StreamReader(ns);

                writer.WriteLine(message);
                writer.Flush();

                string response = reader.ReadLine();
                Console.WriteLine("Response " + response);
                message = Console.ReadLine();
            }

            socket.Close();
        }
    }
}
