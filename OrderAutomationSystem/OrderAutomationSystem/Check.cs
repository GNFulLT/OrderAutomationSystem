using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    internal class Check:Payment
    {
        internal int BankID { get; private set; }
        internal string CheckName { get; private set; }

       internal Check(int amount,int bankID,string name) : base(amount)
        {
            BankID = bankID;
            this.CheckName = name;
        }

        public bool authorized()
        {
            return true;
        }

    }
}
