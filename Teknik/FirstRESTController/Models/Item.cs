using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRESTController.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quality { get; set; }
        public int Quantaty { get; set; }


        public Item() { }


        public override string ToString()
        {
            return $"{ID}: {Name}: Amount: {Quantaty}";
        }
    }
}
