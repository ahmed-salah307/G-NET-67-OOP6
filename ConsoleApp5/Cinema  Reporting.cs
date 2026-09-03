using System;
using System.Collections.Generic;
using System.Text;



namespace CinemaSystem
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");
            for (int i = 0; i < _tickets.Count; i++)
            {
                var t = _tickets[i];
                string status = t.IsBooked ? "Yes" : "No";

                if (t is StandardTicket st)
                {
                    Console.WriteLine($"[Ticket #{i + 1}] {st.MovieName} | Standard | Seat: {st.SeatNumber} | Price: {st.BasePrice} | Final: {st.CalculateFinalPrice():F2} | Booked: {status}");
                }
                else if (t is VipTicket vt)
                {
                    string lounge = vt.HasLoungeAccess ? "Yes" : "No";
                    Console.WriteLine($"[Ticket #{i + 1}] {vt.MovieName} | VIP | Lounge: {lounge} | Fee: {vt.LoungeFee} | Price: {vt.BasePrice} | Final: {vt.CalculateFinalPrice():F2} | Booked: {status}");
                }
                else if (t is ImaxTicket it)
                {
                    string is3d = it.Is3D ? "Yes" : "No";
                    Console.WriteLine($"[Ticket #{i + 1}] {it.MovieName} | IMAX | 3D: {is3d} | Price: {it.BasePrice} | Final: {it.CalculateFinalPrice():F2} | Booked: {status}");
                }
            }
            Console.WriteLine();
        }

        public Ticket[] GetTicketsArray()
        {
            return _tickets.ToArray();
        }
    }
}