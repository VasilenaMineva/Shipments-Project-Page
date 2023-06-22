using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPMENTS
{
    public class StupidShipment : Shipments,IPrint, IComparable<StupidShipment>
    {

        private double arrivalDate;
        private double sendingDate;

        public double ArrivalDate
        {
            get { return arrivalDate; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Invalid Arrival Date.");
                }
                arrivalDate = value;
            }
        }

        public double SendingDate
        {
            get { return sendingDate; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Invalid Sending Date.");
                }
                sendingDate = value;
            }
        }

        public StupidShipment(string inventoryNumber, string type, string headStation,
            string endStation, double arrivalDate, double sendingDate) : base(inventoryNumber, headStation, endStation, type)
        {
            this.arrivalDate = arrivalDate;
            this.sendingDate = sendingDate;
        }

        public int CompareTo(StupidShipment other)
        {
            int result = this.arrivalDate.CompareTo(other.sendingDate);
            if (result == 0)
            {
                result = this.sendingDate.CompareTo(other.sendingDate);
            }
            return result;
        }
        public override double CalculateStayDuration()
        {
            double stayTime = SendingDate - ArrivalDate;
            return stayTime;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Shipment arrival date: {this.ArrivalDate} and sending date: {this.SendingDate}");
        }
    }
}
