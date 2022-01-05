using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using static System.Console;
using static Concert_Dungeon.POCOs;

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
            Clear();
            Write("Welcome my son to the machine followed by an explanation of goals");
            WriteLine("Choose which direction to go: \n" +
                "1. Parking Lot A \n" +
                "2. Parking Lot B \n" +
                "3. Parking Lot C \n" +
                "4. North Entrance \n" +
                "5. South Entrance \n" +
                "6. East Entrance \n" +
                "7. Bathroom \n" +
                "8. Box Office \n");

            string userinput = ReadLine();

            switch (userinput)
            {
                case "1":
                    ParkingLotA();
                    break;
                case "2":
                    ParkingLotB(); 
                    break;
                case "3":
                    ParkingLotC();
                    break;
                case "4":
                    NorthEnterance();
                    break;
                case "5":
                    SouthEnterance();
                    break;
                case "6":
                    EastEnterance();
                    break;
                case "7":
                    Bathroom();
                    break;
                case "8":
                    BoxOffice();
                    break;
                default:
                    WriteLine("Please enter a valid selection");
                    Thread.Sleep(500);
                    break;
            }
        }

        public bool BoxOffice()
        {

            if (hasTicket==true)
            {
                WriteLine("Enjoy the concert");
            }
            else
            {
                //offer to sell ticket if 
            }

        }

        private void Bathroom()
        {
            throw new NotImplementedException();
        }

        private void EastEnterance()
        {
            throw new NotImplementedException();
        }

        private void SouthEnterance()
        {
            throw new NotImplementedException();
        }

        private void NorthEnterance()
        {
            throw new NotImplementedException();
        }

        private void ParkingLotC()
        {
            throw new NotImplementedException();
        }

        private void ParkingLotB()
        {
            throw new NotImplementedException();
        }

        private void ParkingLotA()
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
