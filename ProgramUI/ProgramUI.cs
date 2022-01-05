using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using static System.Console;

namespace ProgramUI
{
    public class ProgramUI
    {

        static void Main(string[] args)
        {
            string[] HP = new string[]
            {
                "HP = 100"
                
            }
            public bool HPCheck()
            {
                if (HP != 0)
                {
                    return true;
                }
                else (HP <= 0);
                {
                    Clear();
                    WriteLine("You have been shut out and drove 8 hours for nothing");
                    Thread.Sleep(1500);
                    return false;
                }
            }
        }
    }
}
