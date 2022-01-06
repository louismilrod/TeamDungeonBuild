using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace POCO_Directory
{
    public class Character
    {
        public Character(bool hasTicket, bool hasLadder, bool hasVest, bool hasClipBoard, bool hasMoney)
        {
            HasTicket = hasTicket;
            HasLadder = hasLadder;  
            HasVest = hasVest;
            HasClipBoard = hasClipBoard;  
            HasMoney = hasMoney;

        }

        public Character()
        {

        }
        
        public bool HasTicket { get; set; }
        public bool HasLadder { get; set; }
        public bool HasVest { get; set; }
        public bool HasClipBoard { get; set; }

        public bool HasMoney { get; set; }

        public bool ScalpedTicket
        {
            get
            {
                Random ticket = new Random();
                int x = ticket.Next(0, 50);
                return (x > 25);                
            }
            
        }

        public int PlayerNameInt { get; set; }

        public bool HasAllThreeItems
        {
            get { return false ; }
             
            set 
            { 
               if (HasClipBoard==true && HasLadder==true && HasVest==true)
                {
                    return;
                }

            }        
        }

    }
}
