using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CarLibrary;

namespace CarServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car server ready");

            TcpListener listner = new TcpListener(IPAddress.Any, 10002);
            listner.Start();

            while (true)
            {
                TcpClient socket = listner.AcceptTcpClient();
                Console.WriteLine("New Client");

                Task.Run(() =>
                {
                    HandleClient(socket);
                });
            }

        }
        public static void HandleClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);

            //string personJson = reader.ReadLine();
            //string carJson = reader.ReadLine();

            //Person person = JsonSerializer.Deserialize<Person>(personJson);
            //person.Cars = JsonSerializer.Deserialize<List<Car>>(carJson);

            string msg = reader.ReadLine();
            TextReader textReader = new StringReader(msg);

            XmlSerializer personSerilizer = new XmlSerializer(typeof(Person));
            Person person = (Person)personSerilizer.Deserialize(textReader);

            Console.WriteLine();

            Console.WriteLine(person.Name);

            foreach(Car car in person.Cars)
            {
                Console.WriteLine($"Car model: {car.Model}, Color: {car.Color}," +
                                $"Registration number: {car.RegNum}");
            }

            writer.WriteLine("Cars recieved, bitch boii");
            writer.Flush();

            socket.Close();
        }
    }
}
