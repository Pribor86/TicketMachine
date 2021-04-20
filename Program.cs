using System;

namespace TicketMachine1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ticket t1 = new Ticket("Sherlock Holmes");
            //Ticket t2 = new Ticket("Mission Impossible");
            //Ticket t3 = new Ticket("Sherlock Holmes");
            //Ticket t4 = new Ticket("Mission Impossible");
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t1.Equals(t2));
            //Console.WriteLine(t1.Equals(new Ticket("Mission Impossible")));
            //Console.WriteLine(t1.Equals(t1));
            TicketMachine m1 = new TicketMachine();
            TicketMachine m2 = new TicketMachine();
            Ticket t1 = m1.BuyTicket("Sherlock Holmes");
            Ticket t2 = m2.BuyTicket("Mission Impossible");
            Ticket t3 = m1.BuyTicket("Sherlock Holmes");
            Ticket t4 = m1.BuyTicket("Mission Impossible");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine("\n\n");
            Console.WriteLine("{0,-40}-isValid(t1)-{1}", t1, m1.IsValid(t1));//-> true
            Console.WriteLine("{0,-40}-isValid(t2)-{1}", t2, m1.IsValid(t2));//-> true
            m1.UseTicket(t1); // -> "Have a nice day!!"
            m2.UseTicket(t2); // -> "Have a nice day!!"
            Console.WriteLine("{0,-40}-isValid(t1)-{1}", t1, m2.IsValid(t1));//-> false
            Console.WriteLine("{0,-40}-isValid(t2)-{1}", t2, m1.IsValid(t2));//-> false
            m2.UseTicket(t1); // ->"ALARM! ticket is not valid!"
            /***************************************/
            Console.WriteLine("\n");
            Ticket myTicket = new Ticket("Sherlock");
            Console.WriteLine(myTicket);
            Console.WriteLine("myTicket.isValid()-" + m1.IsValid(myTicket));// -> false
            m1.UseTicket(myTicket); // ->"ALARM! ticket is not valid!"
        }
    }
}
