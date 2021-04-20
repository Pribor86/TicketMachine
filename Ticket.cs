using System;
namespace TicketMachine1_0
{
    class Ticket
    {
        string movieName;
        int serialNumber;

        static int nextNumber = 1001;


        public Ticket(string movieName)
        {
            this.movieName = movieName;
            serialNumber = nextNumber++;
        }

        public override bool Equals(Object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Ticket))
            {
                return false;   
            }
            Ticket t = (Ticket)obj;


            return movieName.Equals(t.movieName) && serialNumber == t.serialNumber;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("#Ticket [{0,4}, {1}]", serialNumber, movieName);
        }
    }
}
