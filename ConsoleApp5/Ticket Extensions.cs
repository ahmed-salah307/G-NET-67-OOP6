using System;
using System.Collections.Generic;
using System.Text;



namespace CinemaSystem
{
    public static class TicketExtensions
    {
        // Extension method for individual Ticket
        public static string GenerateReceipt(this Ticket ticket)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========== RECEIPT ==========");
            sb.AppendLine($"Movie   : {ticket.MovieName}");
            sb.AppendLine($"Type    : {ticket.GetType().Name}");
            sb.AppendLine($"Price   : {ticket.BasePrice}");
            sb.AppendLine($"Final   : {ticket.CalculateFinalPrice():F2}");
            sb.AppendLine($"Status  : {(ticket.IsBooked ? "Booked" : "Not Booked")}");
            sb.Append("=============================");
            return sb.ToString();
        }

        // Extension method for array of Tickets
        public static double CalculateTotalRevenue(this Ticket[] tickets)
        {
            double total = 0;
            foreach (var ticket in tickets)
            {
                if (ticket.IsBooked)
                {
                    total += ticket.CalculateFinalPrice();
                }
            }
            return total;
        }
    }
}