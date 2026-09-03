using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    public class ImaxTicket : Ticket
    {
        public bool Is3D { get; set; }

        public ImaxTicket(string movieName, double basePrice, bool is3D)
            : base(movieName, basePrice)
        {
            Is3D = is3D;
        }

        public override double CalculateFinalPrice()
        {
            double extraFee = Is3D ? 30 : 0;
            return (BasePrice + extraFee) * 1.14;
        }
    }
}