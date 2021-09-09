using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNum { get; set; }


        public Car(string model, string color, string regnum)
        {
            Model = model;
            Color = color;
            RegNum = regnum;
        }

        public Car() { }
    }
}
