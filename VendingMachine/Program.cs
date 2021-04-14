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
            SnackVendingMachine VM = new SnackVendingMachine();
            do
            {
                VM.showItems();
                VM.readInput();
                VM.BuySnack();
            } while (true);
            
        }
    }
}
