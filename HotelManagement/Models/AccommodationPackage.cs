using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class AccommodationPackage
    {
        public int Id { get; set; }
        public int AccommodationTypeId { get; set; }
        public AccomodationType Accomodation { get; set; }
        public string Name { get; set; }
        public int  NoOfRooms { get; set; }
        public decimal FeePerNight { get; set; }
    }
}