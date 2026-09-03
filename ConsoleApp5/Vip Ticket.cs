using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    public class VipTicket : Ticket
    {
        public bool HasLoungeAccess { get; set; }
        public double LoungeFee { get; set; }

        public VipTicket(string movieName, double basePrice, bool hasLoungeAccess, double loungeFee)
            : base(movieName, basePrice)
        {
            HasLoungeAccess = hasLoungeAccess;
            LoungeFee = loungeFee;
        }

        public override double CalculateFinalPrice()
        {
            return (BasePrice + LoungeFee) * 1.14;
        }
    }
}
