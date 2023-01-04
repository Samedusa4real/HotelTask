using HotelTask4.Services.Implementations;
using System.Reflection.Metadata.Ecma335;

RoomService roomService = new RoomService();

while (true)
{
    Console.WriteLine("HOTEL RESERVATION APP");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1.YENI OTAQ YARATMAQ UCUN CLICKLEYIN,");
    Console.WriteLine("2.BUTUN OTAQLARI GORMEK UCUN CLICKLEYIN,");
    Console.WriteLine("3.OTAQ REZERV ETMEK UCUN CLICKLEYIN,");
    Console.WriteLine("4.PROGRAMDAN CIXMAQ UCUN CLICKLEYIN.");

    string choose = Console.ReadLine();


    switch (choose)
    {
        case "1":
            Console.WriteLine("Otagin adini ve qiymetini daxil edin;");
            try
            {
                roomService.Create(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            catch (Exception)
            {
                Console.WriteLine("Duzgun daxil edin!");
            }
            break;
        case "2":
            Console.Clear();
            roomService.AllInfo();
            break;
        case "3":
            int id; 
            Console.WriteLine("Rezervasiya etmek istediyiniz otagin ID'sini daxil edin;");
            do
            {
                try
                {
                    id = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun daxil edin!...;");
                }
            } while (true);

            roomService.Reservation(id);
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Siz cixis etdiniz!");
            return;
        default:
            Console.Clear();
            Console.WriteLine("Duzgun secin!");
            break;
    }
}
