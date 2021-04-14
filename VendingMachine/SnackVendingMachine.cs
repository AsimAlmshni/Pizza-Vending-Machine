using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class SnackVendingMachine : VendingMachine,Buy, KeyPadAction
    {
        private static string keyPadInput = "0";
        private string slotKeyPadInput = "0";
        private double total = 0;
        private Snack item = null;
        public SnackVendingMachine():base()
        {
            name = "Asim Snack Vending Machine";
            type = "Vending Machine";
        }

        public void BuySnack()
        {
            
            Double doubleVal = 0;
            Msgs.showMsg("Choose your payment Solt:");
            Msgs.showMsg("[1]- Coin");
            Msgs.showMsg("[2]- Note");
            Msgs.showMsg("[3]- Card");

            readSlotInput();

            if (slotKeyPadInput == "1")
            {
                Msgs.showMsg("enter Coins money in USD Currency before bicking:");
                Msgs.showMsg("Total inserted money :" + total);
                var EnteredCoin = Console.ReadLine();



                if (Double.TryParse(EnteredCoin, out doubleVal))
                {
                    if (doubleVal == 50 || doubleVal == 10 || doubleVal == 20)
                    {
                        doubleVal = doubleVal / 100;
                    }
                    if (ValidateCash.validateInsertedCoin(EnteredCoin))
                    {
                        total += doubleVal;
                        if (Shared.SnacksAmount.TryGetValue(keyPadInput, out item))
                        {
                            if (item.Count > 0)
                            {
                                Msgs.ShowPrice(item.Price, item.Count);

                                if (ValidateCash.validateCashInput(item.ID1, item.Price, total) == true)
                                {
                                    if (item.Count > 0)
                                    {
                                        Msgs.showMsg("BonApitite");
                                        var invo = new Invoice(item.ID1, (total - item.Price).ToString());
                                        invo.ShowBill();
                                        item.Count -= 1;
                                        total = 0;
                                    }
                                    else
                                    {
                                        Msgs.showMsg("This Type of Snacks is Unavailable");
                                    }
                                }
                            }
                            else Msgs.showMsg("there is no Snacks of this Choice");
                        }
                        else
                        {
                            Exceptions.showError("Ivalid Choice, Chose from the vending machnie Snack IDs");
                        }

                    }
                    else
                        Exceptions.showError("the input is invalid");
                }
                else
                    Exceptions.showError("the input is invalid");
            }

            else if (slotKeyPadInput == "2") {
                Msgs.showMsg("enter Note money in USD Currency before bicking:");
                Msgs.showMsg("Total inserted money :" + total);
                var totalEnteredNote = Console.ReadLine();


                if (Double.TryParse(totalEnteredNote, out doubleVal))
                {
                    if (ValidateCash.validateInsertedNote(totalEnteredNote))
                    {
                        total += doubleVal;
                        if (Shared.SnacksAmount.TryGetValue(keyPadInput, out item))
                        {
                            if (item.Count > 0)
                            {
                                Msgs.ShowPrice(item.Price, item.Count);

                                if (ValidateCash.validateCashInput(item.ID1, item.Price, total) == true)
                                {
                                    if (item.Count > 0)
                                    {
                                        Msgs.showMsg("BonApitite");
                                        var invo = new Invoice(item.ID1, (total - item.Price).ToString());
                                        invo.ShowBill();
                                        item.Count -= 1;
                                        total = 0;
                                    }
                                    else
                                    {
                                        Msgs.showMsg("This Type of Snacks is Unavailable");
                                    }
                                }
                            }
                            else Msgs.showMsg("there is no Snacks of this Choice");
                        }
                        else
                        {
                            Exceptions.showError("Ivalid Choice, Chose from the vending machnie Snack IDs");
                        }

                    }
                    else
                        Exceptions.showError("the input is invalid");
                }
                else
                    Exceptions.showError("the input is invalid");
            }

            else if (slotKeyPadInput == "3")
            {
                Msgs.showMsg("Type Card to use Card Payment");
                Msgs.showMsg("Total inserted money :" + total);
                var totalEnteredNote = Console.ReadLine();


                if (totalEnteredNote == "Card")
                {
                    if (ValidateCash.validateInsertedCard(totalEnteredNote))
                    {
                        if (Shared.SnacksAmount.TryGetValue(keyPadInput, out item))
                        {
                            if (item.Count > 0)
                            {
                                Msgs.ShowPrice(item.Price, item.Count);

                                if (ValidateCash.validateCashInput(item.ID1, item.Price, item.Price) == true)
                                {
                                    if (item.Count > 0)
                                    {
                                        Msgs.showMsg("BonApitite");
                                        var invo = new Invoice(item.ID1, (item.Price - item.Price).ToString());
                                        invo.ShowBill();
                                        item.Count -= 1;
                                    }
                                    else
                                    {
                                        Msgs.showMsg("This Type of Snacks is Unavailable");
                                    }
                                }
                            }
                            else Msgs.showMsg("there is no Snacks of this Choice");
                        }
                        else
                        {
                            Exceptions.showError("Ivalid Choice, Chose from the vending machnie Snack IDs");
                        }

                    }
                    else
                        Exceptions.showError("the input is invalid");
                }
                else
                    Exceptions.showError("the input is invalid");
            }
        }

        public void showItems() {
            Console.WriteLine("\n\t\tPlease choose based on each item ID" );
            int breakLine = 0;
            Console.WriteLine("___________________________________________________________________________");
            Console.Write("     ");
            foreach (var item in Shared.SnacksAmount)
            {
                if (breakLine % 5 == 0) {
                    Console.WriteLine();

                }
                Console.Write("|" + item.Value.Name + "|"+item.Key+ "|     ");
                breakLine += 1;
            }

            Console.WriteLine("\n___________________________________________________________________________\n");

        }
        public void readInput() {
            keyPadInput = Console.ReadLine();
        }

        public void readSlotInput()
        {
            this.slotKeyPadInput = Console.ReadLine();
        }
    }
}
