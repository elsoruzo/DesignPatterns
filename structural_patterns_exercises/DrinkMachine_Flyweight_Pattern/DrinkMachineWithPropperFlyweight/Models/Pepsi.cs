using System;
using System.Collections.Generic;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class Pepsi : IDrinkCupFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }

        public int CupSize { get; set; }

        private IEnumerable<string> _ingredients;

        public Pepsi()
        {
            _name = "Pepsi";
            _ingredients = new List<string>()
            {
                "Coffee Beans",
                "Fizzy Water",
                "Suggar",
                "Pepsi essence"
            };
        }

        public void Serve()
        {
            Console.WriteLine($"- Cup size {CupSize} ml. {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}