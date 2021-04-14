using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Payment;

namespace VendingMachine
{
    static class Shared
    {
        internal static Dictionary<string, Coin> rout =
             new Dictionary<string, Coin>();

        internal static Dictionary<string, Note> routNote =
     new Dictionary<string, Note>();

        internal static Dictionary<string, Card> routCard =
     new Dictionary<string, Card>();

        internal static Dictionary<string, Snack> SnacksAmount =
     new Dictionary<string, Snack>();
        static Shared() {
            //Coins
            rout.Add("1", new Coin("1", "USD", "1", 50));
            rout.Add("10", new Coin("10", "Cents", "1", 7));
            rout.Add("20", new Coin("20", "Cents", "1", 9));
            rout.Add("50", new Coin("50", "Cents", "1", 20));

            //Notes
            routNote.Add("20", new Note("20", "USD", "2", 50));
            routNote.Add("50", new Note("20", "USD", "2", 7));

            //Cards
            routCard.Add("1", new Card("Card", "USD", "3", 1));

            //Snaks data
            SnacksAmount.Add("1", new Snack("Cheese", 12, "Cheese ", 1, 4.00));
            SnacksAmount.Add("2", new Snack("Cola", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("3", new Snack("Ships", 9, "Tasali", 3, 2.00));
            SnacksAmount.Add("4", new Snack("XL", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("5", new Snack("Bisquet", 9, "Tasali", 3, 2.00));

            SnacksAmount.Add("6", new Snack("Cheese", 12, "Cheese ", 1, 4.00));
            SnacksAmount.Add("7", new Snack("Cola", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("8", new Snack("Ships", 9, "Tasali", 3, 2.00));
            SnacksAmount.Add("9", new Snack("XL", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("0", new Snack("Bisquet", 9, "Tasali", 3, 2.00));

            SnacksAmount.Add("11", new Snack("Cheese", 12, "Cheese ", 1, 4.00));
            SnacksAmount.Add("21", new Snack("Cola", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("31", new Snack("Ships", 9, "Tasali", 3, 2.00));
            SnacksAmount.Add("41", new Snack("XL", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("51", new Snack("Bisquet", 9, "Tasali", 3, 2.00));

            SnacksAmount.Add("12", new Snack("Cheese", 12, "Cheese ", 1, 4.00));
            SnacksAmount.Add("22", new Snack("Cola", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("32", new Snack("Ships", 9, "Tasali", 3, 2.00));
            SnacksAmount.Add("42", new Snack("XL", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("52", new Snack("Bisquet", 9, "Tasali", 3, 2.00));

            SnacksAmount.Add("13", new Snack("Cheese", 12, "Cheese ", 1, 4.00));
            SnacksAmount.Add("23", new Snack("Cola", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("33", new Snack("Ships", 9, "Tasali", 3, 2.00));
            SnacksAmount.Add("43", new Snack("XL", 1, "Drink", 2, 3.00));
            SnacksAmount.Add("53", new Snack("Bisquet", 9, "Tasali", 3, 2.00));
        }

    }
}
