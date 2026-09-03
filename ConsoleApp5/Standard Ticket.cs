using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, double basePrice, string seatNumber)
            : base(movieName, basePrice)
        {
            SeatNumber = seatNumber;
        }

        public override double CalculateFinalPrice()
        {
            
            return BasePrice * 1.14;
        }
    }
}
