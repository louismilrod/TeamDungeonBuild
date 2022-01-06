using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Threading;


namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Title art";
            string title = @"
   ______                           __     ____                  __ 
  / ____/___  ____  ________  _____/ /_   / __ \__  _____  _____/ /_
 / /   / __ \/ __ \/ ___/ _ \/ ___/ __/  / / / / / / / _ \/ ___/ __/
/ /___/ /_/ / / / / /__/  __/ /  / /_   / /_/ / /_/ /  __(__  ) /_  
\____/\____/_/ /_/\___/\___/_/   \__/   \___\_\__,_/\___/____/\__/  
                                                                    
";
            WriteLine(title);
            WriteLine("The most rockin Console App today!\n" +
                "Press any key to continue...");
            ReadKey();
            ProgramUI ui = new ProgramUI();
            ui.Run();

        } 
    }
}
