using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Payment
{
    class Note : Money
    {
        internal Note(string currecyID,
                      string currncy,
                      string typ,
                      double amunt) : base(currecyID, currncy, typ, amunt)
        {
            currencyID = currecyID;
            currency = currncy;
            type = typ;
            amount = amunt;
        }
    }
}
