using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class Exceptions
    {
        public static string Error;

        public static void showError(string error) {
            Console.WriteLine(error);
        }


    }
}
