using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPMENTS
{
    public abstract class Shipments: IPrint
    {
        private string inventoryNumber;
        private string headStation;
        private string endStation;
        private string type;
        public string InventoryNumber
        {
            get { return inventoryNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The inventory number is too short ! ");
                } 
                this.inventoryNumber= value;
            }
            
        }
        public string HeadStation
        {
            get { return headStation; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid information! ");
                }
                this.headStation = value;
            }
        }

        public string EndStation
        {
            get { return endStation; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid information! ");
                }
                this.endStation = value;
            }
        }

        

        public string Type
        {
            get { return type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid information! ");
                }
                this.type = value;
            }
        }

        public Shipments(string inventoryNumber, string headStation, string endStation, string type)
        {
            this.inventoryNumber = inventoryNumber;
            this.headStation = headStation;
            this.endStation = endStation;
            this.type = type;
        }
        public abstract double CalculateStayDuration();
        public virtual void Print()
        {
            Console.WriteLine($"Inventory number: {this.inventoryNumber} Head station: {this.headStation} " +
                $"End Station: {this.endStation} Shipment type: {this.type}");
        }

    }
}
