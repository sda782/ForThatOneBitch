using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Xml.Serialization;
using CarLibrary;

namespace CarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Program");

            TcpClient socket = new TcpClient("localhost", 10002);

            Console.WriteLine("Your name??");
            string name = Console.ReadLine();

            Console.WriteLine("Your address?");
            string address = Console.ReadLine();

            Person person = new Person(name, address);
            Console.WriteLine("test 1");
            AddCars(person);
            Console.WriteLine("Test 2");

            NetworkStream ns = socket.GetStream();

            StreamWriter writer = new StreamWriter(ns);
            StreamReader reader = new StreamReader(ns);

            //string serilizedPerson = JsonSerializer.Serialize(person);
            //string serializedCar = JsonSerializer.Serialize(person.Cars);
            
            XmlSerializer personSerilizer = new XmlSerializer(typeof(Person));

            StringWriter sw = new StringWriter();
            personSerilizer.Serialize(sw, person);

            string msg = sw.ToString().Replace("\r\n", "");
            Console.WriteLine("Test 3");
            writer.WriteLine(msg);
            writer.Flush();

            string response = reader.ReadLine();
            Console.WriteLine("Response " + response);

            socket.Close();
        }

        public static void AddCars(Person person)
        {
            Console.WriteLine($"Welcome {person.Name}");

            while (true)
            {
                Console.WriteLine("Add new cars? (y/n)\n");

                string choice = Console.ReadLine();

                if(choice.Equals("n"))
                {
                    break;
                }

                Console.WriteLine("What Car Model?");
                string carModel = Console.ReadLine();

                Console.WriteLine("What Car Color?");
                string carColor = Console.ReadLine();

                Console.WriteLine("Car Reg. Number?");
                string carReg = Console.ReadLine();

                Car car = new Car(carModel, carColor, carReg);

                person.Cars.Add(car);
            }
        }
    }
}
