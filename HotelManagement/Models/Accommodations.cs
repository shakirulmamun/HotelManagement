using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Accommodations
    {
        public int Id { get; set; }
        public int AccommodationPackageId { get; set; }
        public AccommodationPackage AccommodationPackage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}