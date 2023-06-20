using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPMENTS
{
    public class StupidShipment : Shipments
    {
        public override TimeSpan CalculateStayTime()
        {
            return SendingDate - ArrivalDate;
        }
    }
}
