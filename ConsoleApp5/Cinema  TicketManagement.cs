using System;
using System.Collections.Generic;
using System.Text;



namespace CinemaSystem
{
    public partial class Cinema
    {
        private List<Ticket> _tickets = new List<Ticket>();

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
            Console.WriteLine("Projector ON\n");
        }

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void BookAllTickets()
        {
            foreach (var ticket in _tickets)
            {
                ticket.Book();
            }
        }

        public void CloseCinema()
        {
            Console.WriteLine("Projector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }
    }
}
