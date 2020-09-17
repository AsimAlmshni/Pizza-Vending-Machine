using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    static class Shared
    {
        internal static Dictionary<string, Money> rout =
             new Dictionary<string, Money>();

        internal static Dictionary<string, Pizza> PizzaAmount =
     new Dictionary<string, Pizza>();
        static Shared() {
            rout.Add("1", new Money("1", "NIS", "1", 50));
            rout.Add("5", new Money("5", "NIS", "1", 1));
            rout.Add("10", new Money("10", "NIS", "1", 7));
            rout.Add("20", new Money("20", "NIS", "1", 4));
            rout.Add("50", new Money("50", "NIS", "1", 20));
            rout.Add("100", new Money("100", "NIS", "1", 15));


            PizzaAmount.Add("1", new Pizza("Cheese Pizza", 12, "Cheese Pizza", 1, 54.00));
            PizzaAmount.Add("2", new Pizza("pepperoni Pizza", 1, "pepperoni Pizza", 2, 30.00));
            PizzaAmount.Add("3", new Pizza("Veggie Pizza", 9, "Veggie Pizza", 3, 90.00));
        }

    }
}
