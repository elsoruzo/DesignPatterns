using System;

namespace BoxesIterator.Models
{
    public class Item
    {
        private string _name;
        public Item(string itemName){ _name = itemName; }

        public void GetName()
        {
            Console.WriteLine(_name);
        }
    }
}