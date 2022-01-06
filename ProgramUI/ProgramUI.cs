﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using static System.Console;
using POCO_Directory;

namespace Program
{
    public class ProgramUI

    {
            public POCO_Repo _repo = new POCO_Repo();                      
        
        //private bool hasTicket;
        //private bool hasMoney;
        //private bool hasClipboard;
               

        public void Run()
        {                
            Seed();
            ShowMenu();
        }

        private void Seed()
        {
            Character character = new Character(false, false, false, false, false);
            _repo.AddCharacterToDirectory(character);

        //    //File.WriteAllLines("@www.github.com/therepo");
        //    //string text = File.ReadAllText(@);
        
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

                string userinput = ReadLine();
                switch (userinput)
                {
                    case "1":
                        ExplorationMenu();
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

        private void ExplorationMenu()
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

            string userinput = ReadLine().ToLower();

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
                    PressEnterance();
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
            WriteLine("You approach the ticket counter.\n\n" +
                "An old man with a thinning ponytail and a Twisted Sister teashirt looks you up and down.\n" +
                "Do you have a ticket?");
            ReadLine();


            if (character.HasTicket==true)
            {
                WriteLine("Enjoy the concert");
            }
            else
            {
                WriteLine("Would you like to puchase a ticket?\n" +
                    "1. Yes\n" +
                    "2. No\n");

                string userinput = ReadLine().ToLower();

                switch (userinput)
                {
                    case "1":
                        if (character.HasMoney == false)
                        {
                            Console.WriteLine("You don't have any money! Get out of here before I call security!");
                        }
                        else YouWin();
                        break;
                    case"2":
                        WriteLine("Then why are you here? Shoo, shoo!");
                        Thread.Sleep(2000);
                        break;
                    case "i wanna rock":
                        WriteLine("'I used to be just like you kid. Don't tell anyone.'" +
                            "He winks at you as he slides you a ticket stub");
                        Thread.Sleep(2000);
                        YouWin();
                        break;
                }
            }
            return true;
            

        }

        public void YouWin()
        {
            WriteLine("Welcome to the greatest concert of your life!"); 
            Thread.Sleep(2000);
            return;
        }

        public void YouLose()
        {
            WriteLine("You did not get in the door and drove eight hours one way for nothing");
            Thread.Sleep(2000);
            return;
        }

        private void Bathroom()  //search the bathroom, talk to someone in the bathroom, search the trash (find an item//clipboard used for cleaning rotation),
        {
            WriteLine("Its dark and dingy and smells bad. \n" +
                "What would you like to do?\n" +
                "1. Look around the bathroom \n" +
                "2. Talk to someone in the bathroom \n" +
                "3. Search the trash can\n" +
                "4. Back");

            string userinput = ReadLine().ToLower();

            switch (userinput)
            {
                case"1":
                    WriteLine("In front of you is a mirror and a sink \n" +
                        "You glance to the left and notice a sticker for the band \n" +
                        "You look to your right and notice an overlfowing trash can");
                    Thread.Sleep(2000);
                    break;
                case "2":
                    WriteLine("Why are you talking to me in the bathroom dude? Do you take picuters of peoples texts too?");
                    Thread.Sleep(2000);
                    break;
                case "3":
                    WriteLine("The trash is overlfowing with Liquid Death \n" +
                        "On the right of the bin there is an empty clipboard with an unused cleaning rotation check list \n" +
                        "Do you want to abscond with this clipboard? Yes/No");
                    if (userinput == "yes")
                    {

                        WriteLine("You have found a clipboard? What you will you do with it?");
                        character.HasClipBoard = true;

                    }
                    else
                    {
                        WriteLine("You left the clipboard where you found it like your mother taught you");
                    }
                    break;
                case"4":
                    ExplorationMenu();
                    break;
                default: WriteLine("The bathroom is a weird place man...");
                    break;
            }
        }

        private void EastEnterance() //normal security gate, ticket guard to interact w/, (guard could stop you)
        {
            

            List<Character> character = _repo.GetCharacter();

            WriteLine("You approach the venue from the east. \n" +
                "You are optimistic the line will be short (it won't be).\n" +
                "What would you like to do?\n" +
                "1. Approach the guard.\n" +
                "2. Try to sneak through the gate");

            string userinput = ReadLine().ToLower();

            switch (userinput)
            {
                case "1":
                    WriteLine("You approach the overweight, sweating guard.\n" +
                        "He looks at you while wipping his face with a handkerchief\n" +
                        "'Do you have a ticket?'");
                    break;
                    if (character.HasLadder == true && character.)
                    {
                        Console.WriteLine('Oh, the safety inspector, come right in, Sir!');
                        Thread.Sleep(3000);
                        YouWin();
                    }
                    else if (hasTicket == true)
                    {
                        Console.WriteLine('Ah, you have a ticket.');
                    }
                    {
                        Console.WriteLine("Come back when you have a ticket");
                    }
                    else if (scalpedTicket)
                    {

                    }
                    break;
                case "2":
                    //whatver the code is

                default:
                    break;
            }

        }  

        private void SouthEnterance() // other concert goers, more relaxed security guy
        {
            throw new NotImplementedException();
        } 

        private void PressEnterance()  //locked enterance, road-crew guy (gives hard hard, asks what band we like more and gives hard hat)
        {
            throw new NotImplementedException();
        }       

        private void ParkingLotC()
        {
            throw new NotImplementedException();
        } //grilled cheese and fancy rocks for sale (vest)

        private void ParkingLotB()
        {
            throw new NotImplementedException();
        } //band tour busses and construction vehicles (ladder)

        private void ParkingLotA()
        {
            throw new NotImplementedException();
        } //scalper guy with sketch ticket, some hippies lost dog

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
