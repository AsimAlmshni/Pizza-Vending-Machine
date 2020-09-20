using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachine : Pizza, Prepare, Buy
    {
        private string keyPadInput = "0";
        private double total = 0;
        private Pizza item = null;
        public VendingMachine()
        {
        }

        public void BuyPizza()
        {
            Double doubleVal = 0;
            Msgs.showMsg("enter money in NIS before bicking:");
            Msgs.showMsg("Total inserted money :"+ total);
            var totalEntered = Console.ReadLine();
            if (Double.TryParse(totalEntered, out doubleVal))
            {
                if (ValidateCash.validateInserted(totalEntered))
                {
                    total += doubleVal;
                    if (Shared.PizzaAmount.TryGetValue(keyPadInput, out item))
                    {
                        if (item.Count > 0)
                        {
                            if (ValidateCash.validateCashInput(item.ID1, item.Price, total) == true)
                            {
                                if (item.Count > 0)
                                {
                                    Bake();
                                    Msgs.showMsg("do you want it sliced or cut");
                                    Msgs.showMsg("type y/Y for yes and n/N for no");
                                    var ans = Console.Read();
                                    if (ans == 'y' || ans == 'Y')
                                    {
                                        cut(item.ID1);
                                        Msgs.showMsg("BonApitite");
                                    }
                                    else if (ans == 'n' || ans == 'N')
                                        Msgs.showMsg("BonApitite");
                                    var invo = new Invoice(item.ID1, (total - item.Price).ToString());
                                    invo.ShowBill();
                                    item.Count -= 1;
                                    total = 0;
                                    box();
                                }
                                else {
                                    Msgs.showMsg("This Type of Pizza is Unavailable");
                                }
                            }
                        }
                        else Msgs.showMsg("there is no Pizza of this Choice");
                    }
                    else
                    {
                        Exceptions.showError("Ivalid Choice, Chose from the vending machnie Pizza IDs");
                    }
                    
                }
                else
                    Exceptions.showError("the input is invalid");
            }
            else
                Exceptions.showError("the input is invalid");

        }

        public void box() {
            Msgs.showMsg("PizzaBoxed");
        }
        public void Bake() {
            Msgs.showMsg("PizzaBaked");
        }

        public void cut(int ID)
        {
            string Diameter = null;           //The diameter of the pizza which the user will enter
            int Slices;                       //The number of slices the user will get
            const double SliceSize = 14.125;  //The area of each slice of pizza
            double Radius;                    //The radius of the pizza
            double Area;                      //The area of the pizza


            //INPUT
            Diameter = "15";
            double Diameter1 = Convert.ToDouble(Diameter);

            //PROCESS
            Radius = Diameter1 / 2;
            Area = Math.PI * Math.Pow(Radius, 2);
            Slices = (int)Math.Round(Area / SliceSize);

            //OUTPUT
            Console.WriteLine("A " + Diameter + "\" pizza will yeild {0:n0} slices", Slices);

        }

        public void showItems() {
            Console.WriteLine("ID\t" + "NAME\t\t\t" + "\tPRICE\t" + "COUNT\t" );

            foreach (var item in Shared.PizzaAmount)
            {
                Console.WriteLine(item.Value.ID1+"\t"+item.Value.Name+"\t\t\t"+item.Value.Price+"\t"+item.Value.Count);
            }
        }
        public void readInput() {
            this.keyPadInput = Console.ReadLine();



        }
    }
}
