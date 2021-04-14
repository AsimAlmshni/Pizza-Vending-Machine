using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Invoice
    {
        private int BillID;
        private string Bill;

        public Invoice() { }
        public Invoice(int BillID, string Bill) {
            this.BillID = BillID;
            this.Bill = Bill;
        }


        public void ShowBill() {
            Msgs.showMsg("Dear Customer your BillID for Order is:   " + BillID + "   and total Recipt :   " + Bill + "  and your exchange is");
            exchangeCalculate(Bill);
        }

        public void exchangeCalculate(string Bill) {
            List<string> lst = new List<string>();
            var temp = Convert.ToDouble(Bill);
            do
            {
                if (temp >= 50)
                {
                    if (Shared.routNote["50"].Amount > 0)
                    {
                        Shared.routNote["50"].Amount -= 1;
                        temp -= 50;
                        lst.Add("50 ");
                    }
                }
                if (temp >= 20)
                {
                    if (Shared.routNote["20"].Amount > 0)
                    {
                        Shared.routNote["20"].Amount -= 1;
                        temp -= 20;
                        lst.Add("20 ");
                    }
                }
                if (temp >= 1)
                {
                    if (Shared.rout["1"].Amount > 0)
                    {
                        Shared.rout["1"].Amount -= 1;
                        temp -= 1;
                        lst.Add("1 ");
                    }
                }
                else if (temp >= .50)
                {
                    if (Shared.rout["50"].Amount > 0)
                    {
                        Shared.rout["50"].Amount -= 1;
                        temp -= .50;
                        lst.Add(".50 ");
                    }
                }
                else if (temp >= .20)
                {
                    if (Shared.rout["20"].Amount > 0)
                    {
                        Shared.rout["20"].Amount -= 1;
                        temp -= .20;
                        lst.Add(".20 ");
                    }
                }
                else if (temp >= .10)
                {
                    if (Shared.rout["10"].Amount > 0)
                    {
                        Shared.rout["10"].Amount -= 1;
                        temp -= .10;
                        lst.Add(".10 ");
                    }
                }
            } while (temp > 0);
            foreach (var item in lst)
            {
                Console.Write(item+"|");
            }
            Console.WriteLine();
        }
    }
}
