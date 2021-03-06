﻿using System;
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
            Msgs.showMsg("Dear Customer your BillID for Order is:" + BillID + "and total Bill :" + Bill + "and your exchange is");
            exchangeCalculate(Bill);
        }

        public void exchangeCalculate(string Bill) {
            List<string> lst = new List<string>();
            var temp = Convert.ToDouble(Bill);
            do
            {
                if (temp >= 100)
                {
                    if (Shared.rout["100"].Amount > 0)
                    {
                        Shared.rout["100"].Amount -= 1;
                        temp -= 100;
                        lst.Add("100 ");
                    }
                }
                if (temp >= 50)
                {
                    if (Shared.rout["50"].Amount > 0)
                    {
                        Shared.rout["50"].Amount -= 1;
                        temp -= 50;
                        lst.Add("50 ");
                    }
                }
                if (temp >= 20)
                {
                    if (Shared.rout["20"].Amount > 0)
                    {
                        Shared.rout["20"].Amount -= 1;
                        temp -= 20;
                        lst.Add("20 ");
                    }
                }
                if (temp >= 10)
                {
                    if (Shared.rout["10"].Amount > 0)
                    {
                        Shared.rout["10"].Amount -= 1;
                        temp -= 10;
                        lst.Add("10 ");
                    }
                }
                if (temp >= 5)
                {
                    if (Shared.rout["5"].Amount > 0)
                    {
                        Shared.rout["5"].Amount -= 1;
                        temp -= 5;
                        lst.Add("5 ");
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
            } while (temp > 0);
            foreach (var item in lst)
            {
                Console.Write(item+"|");
            }
            Console.WriteLine();
        }
    }
}
