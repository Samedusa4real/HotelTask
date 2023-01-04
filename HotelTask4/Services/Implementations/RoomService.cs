using HotelTask4.Models;
using HotelTask4.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask4.Services.Implementations
{
    internal class RoomService:IRoomService
    {
        Hotel hotel = new Hotel();

        public void Create(string name, double price)
        {
            Rooms rooms = new Rooms()
            {
                Name = name,
                Price = price
            };

            Array.Resize(ref hotel.Room, hotel.Room.Length + 1);
            hotel.Room[hotel.Room.Length - 1] = rooms;
        }

        public void AllInfo()
        {
            for (int i=0; i<hotel.Room.Length; i++)
            {
                Console.WriteLine($"{hotel.Room[i].Id} ID'li otag,Adi: {hotel.Room[i].Name}, Qiymeti: {hotel.Room[i].Price}, Rezervasiya veziyyeti:{hotel.Room[i].IsReserved}");
            }
        }

        public void Reservation(int id)
        {
            for (int i = 0; i<hotel.Room.Length;i++)
            {
                if (hotel.Room[i].Id == id)
                {
                    if (hotel.Room[i].IsReserved == false)
                    {
                        Console.WriteLine("Otaq rezerv olundu!");
                        hotel.Room[i].IsReserved = true;
                    }
                    else
                    {
                        Console.WriteLine("Bu otag teessufki doludur!");
                    }
                }
                else
                {
                    Console.WriteLine("Bele otag yoxdur!");
                }
            }
        }
    }
}
