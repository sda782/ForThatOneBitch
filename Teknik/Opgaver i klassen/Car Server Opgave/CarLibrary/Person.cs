using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
            Cars = new List<Car>();
        }

        public Person() { }
    }
}
