using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Concert_Dungeon
{
    public class POCOs
    {
        public int HitPoints { get; set; }
        public bool HasTicket { get; set; }
        public bool HasLadder { get; set; }
        public bool HasVest { get; set; }
        public bool Clipboard { get; set; }

        public int ScalpedTicket
        {
            set
            {
                Random ticket = new Random();
                int x = ticket.Next(0, 50);
                if (x > 25)
                {
                    Console.WriteLine("Welcome to the concert");
                }
                else
                {
                    Console.WriteLine("This ticket is fradulent and you were shamed by security");
                    Thread.Sleep(3000);
                }
            }


        }


    }
}
