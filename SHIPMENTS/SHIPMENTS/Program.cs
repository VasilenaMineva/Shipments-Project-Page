namespace SHIPMENTS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Shipments> shipments = new List<Shipments>();

            Console.Write("Брой пратки за въвеждане: ");
            int n =int.Parse(Console.ReadLine());

            // Въвеждане на данни за пратки
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Въвеждане на данни за пратка {i + 1}:");
                StupidShipment shipment = new StupidShipment();

                try
                {
                    Console.Write("Инвентарен номер: ");
                    shipment.InventoryNumber = Console.ReadLine();

                    Console.Write("Дата на приемане (yyyy-MM-dd): ");
                    shipment.ArrivalDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

                    Console.Write("Дата на изпращане (yyyy-MM-dd): ");
                    shipment.SendingDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

                    Console.Write("Вид на пратката: ");
                    shipment.Type = Console.ReadLine();

                    Console.Write("Начална гара: ");
                    shipment.HedaStation = Console.ReadLine();

                    Console.Write("Крайна гара: ");
                    shipment.EndStation = Console.ReadLine();

                    shipments.Add(shipment);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Грешка при въвеждането на данните за пратката.");
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            

            //// Извеждане на цялата информация за n на брой пратки
            try
            {
                Console.Write("Брой пратки за извеждане: ");
                int num = int.Parse(Console.ReadLine());

                var selectedShipments = shipments.Take(n);

                Console.WriteLine("Цялата информация за пратките:");
                foreach (var shipment in selectedShipments)
                {
                    Console.WriteLine($"Инвентарен номер: {shipment.InventoryNumber}");
                    Console.WriteLine($"Дата на приемане: {shipment.ArrivalDate}");
                    Console.WriteLine($"Дата на изпращане: {shipment.SendingDate}");
                    Console.WriteLine($"Вид на пратката: {shipment.Type}");
                    Console.WriteLine($"Начална гара: {shipment.HedaStation}");
                    Console.WriteLine($"Крайна гара: {shipment.EndStation}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Грешка при извеждането на информацията за пратките.");
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}