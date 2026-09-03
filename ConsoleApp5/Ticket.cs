using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaSystem
{
    public abstract class Ticket
    {
        public string MovieName { get; set; }
        public double BasePrice { get; set; }
        public bool IsBooked { get; protected set; }

        protected Ticket(string movieName, double basePrice)
        {
            MovieName = movieName;
            BasePrice = basePrice;
            IsBooked = false;
        }

        
        public abstract double CalculateFinalPrice();

        public virtual void Book()
        {
            IsBooked = true;
        }

        
        public void Cancel()
        {
            IsBooked = false;
        }
    }
}
