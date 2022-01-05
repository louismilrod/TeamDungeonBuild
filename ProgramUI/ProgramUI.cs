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
        public void Run()
        {                
            Seed();
            ShowMenu();
        }

        private void Seed()
        {
            File.WriteAllLines("@www.github.com/therepo");
            string text = File.ReadAllText(@);
            throw new NotImplementedException();
        }

        private void ShowMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Clear();
                WriteLine("Welcome to your fantastic concert adventure your goal is to get in the door \n" +
                    "1. Start a new run\n" +
                    "2. Load a game \n" + 
                    "3. Delete Game\n" + 
                    "4. Exit \n");
                
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        StartANewGame();
                        break;
                    case "2":
                        LoadAGame();
                        break;
                    case "3":
                        DeleteGame();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default: WriteLine("Please enter a valid selection");
                        Thread.Sleep(500);
                        break;
                }

            }
        }

        private void StartANewGame()
        {
            throw new NotImplementedException();
        }

        private void LoadAGame()
        {
            throw new NotImplementedException();
        }

        private void DeleteGame()
        {
            throw new NotImplementedException();
        }
    }
}
