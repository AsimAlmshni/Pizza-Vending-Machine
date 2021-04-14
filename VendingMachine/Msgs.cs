using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class Msgs
    {
        public static string Msg;

        public static void ShowPrice(double prc, int tempCount)
        {
            Msgs.showMsg("Dear Customer your Order Price \t " + prc + "\t and total amount of it :\t" + tempCount);
        }

        public static void showMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
