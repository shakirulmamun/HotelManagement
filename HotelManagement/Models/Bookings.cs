using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public int AccommodationId { get; set; }
        public Accommodations Accommodations { get; set; }
        public DateTime FromDate { get; set; }
        /// <summary>
        /// No Of Stay Nights
        /// </summary>
        public int Duration { get; set; }
    }
} 