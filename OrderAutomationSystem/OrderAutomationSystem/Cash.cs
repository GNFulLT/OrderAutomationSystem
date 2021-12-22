using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    internal class Cash :Payment
    {
        internal int CashTendered { get; private set; }
        internal Cash(int amount) : base(amount)
        {
            CashTendered = amount;
        }
    }
}
