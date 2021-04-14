using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Money
    {
        protected string currencyID;
        protected string currency;
        protected string type;
        protected double amount;

        internal Money(string currencyID,string currency, string type, double amount) {
            this.currencyID = currencyID;
            this.currency = currency;
            this.type = type;
            this.amount = amount;
        }

        public string CurrencyID { get => currencyID; set => currencyID = value; }
        public string Currency { get => currency; set => currency = value; }
        public string Type { get => type; set => type = value; }
        public double Amount { get => amount; set => amount = value; }

        public double returnExchange() {
            return 0;
        }
        internal bool checkMoneyAmountForExchange() {
            return false;
        }

    }
}
