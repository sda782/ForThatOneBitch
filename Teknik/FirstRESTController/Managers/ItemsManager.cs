using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRESTController.Models;

namespace FirstRESTController.Managers
{
    public class ItemsManager
    {
        private static int _nextId = 1;
        private static readonly List<Item> Data = new List<Item>
        {
            new Item {ID = _nextId++, Name = "C# is nice", Quality = 2, Quantaty = 2},
            new Item {ID =_nextId++, Name = "Python is even nicer", Quality = 5, Quantaty = 2}
        };

        public List<Item> GetAll()
        {
            return new List<Item>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public Item GetById(int id)
        {
            return Data.Find(item => item.ID == id);
        }

        public Item Add(Item item)
        {
            item.ID = _nextId++;
            Data.Add(item);
            return item;
        }

        public Item Delete(int id)
        {
            Item item = Data.Find(item1 => item1.ID == id);
            if (item == null) return null;
            Data.Remove(item);
            return item;
        }

        public Item Update(int id, Item updates)
        {
            Item item = Data.Find(item1 => item1.ID == id);
            if (item == null) return null;
            item.Name = updates.Name;
            item.Quality = updates.Quality;
            item.Quantaty = updates.Quantaty;
            return item;
        }
    }
}
