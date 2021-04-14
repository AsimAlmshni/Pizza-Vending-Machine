using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Snack
    {
        private int ID;
        private string name;
        private int count;
        private string type;
        private double price;

        public Snack() { }
        public Snack(string name, int count, string type, int ID, double price) {
            this.name = name;
            this.count = count;
            this.type = type;
            this.ID = ID;
            this.price = price;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
    }
}
