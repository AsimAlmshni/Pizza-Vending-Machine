using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class ValidateCash
    {
        public static bool validateCashInput(int ID, double price, double enteredAmount) {

            if (enteredAmount >= price)
                return true;
            else
                return false;
        }

        public static bool validateInserted(string inserted) {
            if (inserted == "1" || inserted == "5" || inserted == "10" || inserted == "20" || inserted == "50" || inserted == "100")
                return true;
            else
                return false; 
        
        }
    }
}
