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
        // check the total entered money if it can buy
        public static bool validateCashInput(int ID, double price, double enteredAmount) {

            if (enteredAmount >= price)
                return true;
            else
                return false;
        }

        // validate inserted coins
        public static bool validateInserted(string inserted)
        {
            if (inserted == "1" || inserted == "10" || inserted == "20" || inserted == "50")
                return true;
            else
                return false;

        }

        // validate inserted coins
        public static bool validateInsertedCoin(string inserted) {
            if (inserted == "1" || inserted == "10" || inserted == "20" || inserted == "50")
                return true;
            else
                return false; 
        
        }

        // validate inserted Note
        public static bool validateInsertedNote(string inserted)
        {
            if (inserted == "20" || inserted == "50")
                return true;
            else
                return false;

        }

        // validate inserted coins
        public static bool validateInsertedCard(string inserted)
        {
            if (inserted == "Card")
                return true;
            else
                return false;

        }
    }
}
