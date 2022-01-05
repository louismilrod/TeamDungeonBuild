using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Threading;

namespace ProgramUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
        }
        public void Run()
        {
            string[] HP = new string[]
            {
                "HP = 100"

            }
            File.WriteAllLines(@);
            string text = File.ReadAllText(@);

            
            
        }
        public bool HPCheck()
        {
            if(HP != 0)
            {
                return true;
            }
            else (HP <= 0)
            {
                Clear();
                WriteLine("You have been shut out and drove 8 hours for nothing");
                Thread.Sleep(1500);
                return false;
            }
        }
    }
}
