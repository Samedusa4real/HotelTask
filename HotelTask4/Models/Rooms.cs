using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask4.Models
{
    internal class Rooms
    {

        private int _id = 0;
        public int Id;
        public double Price { get; set; }
        public string Name { get; set; }
        public bool IsReserved { get; set; } = false;

        public Rooms()
        {
            _id++;
            Id = _id;
        }
    }
}
