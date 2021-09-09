using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MyFirstServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Echo server");

            TcpListener listner = new TcpListener(IPAddress.Any, 7);
            listner.Start();

            while (true)
            {
                TcpClient socket = listner.AcceptTcpClient();

                Task.Run(() =>
                {
                    Console.WriteLine("Test1");
                    HandleClient(socket);
                });
            }

        }
        public static void HandleClient(TcpClient socket)
        {
            while (true)
            {

                Console.WriteLine("Hurra, incoming client");

                NetworkStream ns = socket.GetStream();
                StreamReader reader = new StreamReader(ns);
                StreamWriter writer = new StreamWriter(ns);

                string message = reader.ReadLine();


                Console.WriteLine("Request " + message);

                writer.WriteLine(message.ToUpper());
                writer.Flush();

                message = reader.ReadLine();

                if(message.Equals("end"))
                {
                    break;
                }
            }

            socket.Close();
        }

    }

    
}