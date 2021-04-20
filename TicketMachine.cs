using System;
using System.Collections.Generic;
namespace TicketMachine1_0
{
    class TicketMachine
    {
        static List<Ticket> legalTickets = new List<Ticket>();

        public Ticket BuyTicket(string movieName)
        {
            Ticket t = new Ticket(movieName);
            legalTickets.Add(t);
            return t;
        }

        public bool IsValid(Ticket t)
        {
            foreach (Ticket temp in legalTickets)
            {
                if (t.Equals(temp))
                {
                    return true;
                }
            }
            return false;
        }

        public void UseTicket(Ticket t)
        {
            if (!IsValid(t))
            {
                Console.WriteLine("ALARM! {0} ticket is not valid!", t);
            }
            else
            {
                Console.WriteLine("Have a nice day!");
                legalTickets.Remove(t);
            }
        }
        

        
    }
}
