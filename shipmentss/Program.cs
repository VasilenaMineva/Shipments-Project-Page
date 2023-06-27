using System.Threading;
using static System.Collections.Specialized.BitVector32;

namespace SHIPMENTS
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                StupidShipment shipment1 = new StupidShipment("ASDFGHJK", "Documents", "Varna", "Burgas", 5.6, 10.6);
                StupidShipment shipment2 = new StupidShipment("WERTYURT", "Clothes", "Sofia", "Plovdiv", 8.6, 12.6);

                List<StupidShipment> listOfShipments = new List<StupidShipment>() { shipment1,shipment2};

                shipment1.Print();
                shipment2.Print();

                double stayDuration = shipment1.CalculateStayDuration();
                double stayDuration2 = shipment2.CalculateStayDuration();
                Console.WriteLine($"First shipment stay duration: {stayDuration} days");
                Console.WriteLine($"Second shipment stay duration: {stayDuration2} days");

                Console.WriteLine($"Longest stay duration: {stayDuration}");
                using (StreamWriter writer = new StreamWriter("shipment_data.txt"))
                Console.WriteLine("Shipment data saved to shipment_data.txt");


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                throw;

            }
            
        }
    }
}