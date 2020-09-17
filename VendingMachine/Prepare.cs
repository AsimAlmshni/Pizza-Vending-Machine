using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal interface Prepare
    {
        void cut(int ID);
        void box();
        void Bake();
    }
}
