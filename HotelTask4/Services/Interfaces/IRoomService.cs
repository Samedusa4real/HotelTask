using HotelTask4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask4.Services.Interfaces
{
    internal interface IRoomService
    {
        public void Create(string name, double price);

        //Bu hisseninin(AllInfo) typeni Rooms vermisdim ancag o cagirilma hissesinde xeta verdi deye deyismeli oldum, xetani yegin geriye tekce "room" qaytarir deye verdi.
        public void AllInfo();
        public void Reservation(int id);
    }
}
