using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine VM = new VendingMachine();
            do
            {
                VM.showItems();
                VM.readInput();
                VM.BuyPizza();
            } while (true);
            
        }
    }
}
