using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    interface ICustomers
    {
        int CustomerID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        IOrder order { get; set; }
        int Balance { get; set; }

        void takeOrder();

    }
}
