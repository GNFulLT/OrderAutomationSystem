using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    class Order : IOrder
    {
        public int OrderID { get; private set; }
        public DateTime Date { get; set; }
        private string state;
        public Status State { get {
                if(state == "Dağıtımda")
                {
                    return Status.Enroute;
                }
            else if(state == "Beklemede")
                {
                    return Status.OnHold;
                }
            else if(state == "Kargo Şubesinde")
                {
                    return Status.OnCargo;
                }
                else
                {
                    return Status.WaitForCargo;
                }
            } set { 
                if(value == Status.Enroute)
                {
                    state = "Dağıtımda";
                }
                else if(value == Status.OnHold)
                {
                    state = "Beklemede";
                }
                else if (value == Status.OnCargo)
                {
                    state = "Kargo Şubesinde";
                }
                else
                {
                    state = "Merkez Şubede";
                }
            } }
        public OrderDetail Details { get; set; }
    }
}
