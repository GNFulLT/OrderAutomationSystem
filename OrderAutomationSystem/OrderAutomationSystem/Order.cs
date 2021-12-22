using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;

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

        public Order(OrderDetail details)
        {
            Details = details;
            State = Status.WaitForCargo;
            Task<DateTime> dt = getTime();
            Date = dt.Result;
        }

        private async static Task<DateTime> getTime()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://www.google.com");

                var response = await request.GetResponseAsync().ConfigureAwait(false);

                return DateTime.ParseExact(response.Headers["date"],
                                "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                CultureInfo.InvariantCulture.DateTimeFormat,
                                DateTimeStyles.AssumeUniversal);
            }
            catch
            {
                return new DateTime(DateTime.MinValue.Ticks);
            }

            /*using (var response =
          WebRequest.Create("http://www.google.com").GetResponse())
                //string todaysDates =  response.Headers["date"];
                return DateTime.ParseExact(response.Headers["date"],
                    "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                    CultureInfo.InvariantCulture.DateTimeFormat,
                    DateTimeStyles.AssumeUniversal);*/




        }
        internal bool verifyInternet()
        {
            if(this.Date == new DateTime(DateTime.MinValue.Ticks))
            {
                return false;
            }
            else
            {
                return true;
            }
        } 

    }
}
