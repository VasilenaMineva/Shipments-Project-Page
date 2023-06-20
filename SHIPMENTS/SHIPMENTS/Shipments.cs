using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPMENTS
{
    public abstract class Shipments
    {
        public string InventoryNumber { get; set; }//Инвентарен номер;
        public DateTime ArrivalDate { get; set; }//Дата на приемане;
        public DateTime SendingDate { get; set; }//Дата на изпращане; 
        public string Type { get; set; }//Вид на пратката;
        public string HedaStation { get; set; }//Начална гара; 
        public string EndStation { get; set; }//Крайна гара.

        public abstract TimeSpan CalculateStayTime();

    }
}
