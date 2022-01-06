using System;
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
                    default:
                        WriteLine("Please enter a valid selection");
                        Thread.Sleep(500);
                        break;
                }

            }
        }

        private void ExplorationMenu()
        {
            Clear();
            Write("Welcome my son to the machine");
            WriteLine("Choose which direction to go: \n" +
                "1. Parking Lot A \n" +
                "2. Parking Lot B \n" +
                "3. Parking Lot C \n" +
                "4. Press Entrance \n" +
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
                    PressEntrance();
                    break;
                case "5":
                    SouthEntrance();
                    break;
                case "6":
                    EastEntrance();
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
            var character = _repo.GetCharacter();
            string userinput = ReadLine().ToLower();


            WriteLine("You approach the ticket counter.\n" +
                "An old man with a thinning ponytail and a Twisted Sister t-shirt looks you up and down.\n" +
                "Do you have a ticket?");
            ReadLine();

            if (character.HasScalpedticket == true)
            {
                WriteLine("'You sure this thing is real?' the ticket taker asks.");
                Thread.Sleep(1750);
                if (character.ScalpedTicket == true)
                {
                    WriteLine("'Huh, guess it worked. Enjoy the show'");
                    Thread.Sleep(2500);
                    YouWin();
                }
                else 
                {
                    WriteLine("I knew it was too good to be true!\n" +
                        "That ticket was a total fake!");
                    Thread.Sleep(3000);
                    YouLose();
                }

            }
            if (character.HasTicket == true)
            {
                WriteLine("Enjoy the concert");
                Thread.Sleep(2500);
                YouWin();
            }
            else
            {
                WriteLine("Would you like to puchase a ticket?\n" +
                    "1. Yes\n" +
                    "2. No \n");

                if (character.HasMoney == true)
                {
                    WriteLine("Here's your ticket boy-o");
                    character.HasTicket = true;
                    return BoxOffice();
                }
                else
                {
                    Console.WriteLine("Then why did you come here?");
                    ExplorationMenu();
                }



                switch (userinput)
                {
                    case "1":
                        if (character.HasMoney == false)
                        {
                            Console.WriteLine("You don't have any money! Get out of here before I call security!");
                        }
                        else YouWin();
                        break;
                    case "2":
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
            Console.Title = "Youwin";
            string Youwin = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0OxdollccclllllllllllllllodxO0KNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0kdl:,',,;;clodxkO00KKKKKK000Okxdol::;;,;:ldk0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKkoc,....,cok0XNWNXK0OkxxddddodddxxkO0XNWMWNKOdl;'...;cokKNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOdc,.   .;okKWWN0kdl:;,'..................',;:ldk0XWWN0xl,.  .,cdONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOd:'..  .;lkXWNKxo:,......''''''''''''''''''''''......,;lx0NWN0x:.   .':d0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXkc,......;d0NWXkl;'....'''''''''''''''''''''''''''''''''''....,cd0WWXkc'.....,lkXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXx:.......'o0NWKxc,...''''''''''''''''''''''''''''''''''''''''''..   .,o0NWXx:......'ckXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMNkc'.......;xNWXkc'..'''''''''''''''''''''''''''''''''''''''''....';cc. ....;dKWNOc...'...'lONMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMWKd,........:ONW0o,..''''''''''''''''''''''''''''''''''''''''....':okKWK: ........:kNW0l'..''...,dKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMWOc.........:OWNOc...'''''''''''''''''''''''''''''''''''''''... .;o0NWWMK:............;xNWKl..'''....l0WMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMNk;. .......;kNWO:..''''''''''''''''''''''''''''''''''''''''''.... ..,lONX: ..............,xNW0:..''''...:ONMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWO;. ........dNW0c..'''''''''''''''''''''''''''''''''''''''''''.....,cdOXWK: .................;OWNk,..'''.. .:OWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO:. ........;0WNd...''''''''''''''''''''''''''''''''''''''''....':lxKNMMWW0;  ..';,.  ...........lXMKc..'''''. .c0WMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMXl. .........oXW0;..'''''''''''''''''''''''''''''''''''''.....,cdOXWMMMMMMMNxloxO00d,...............,kWNx'.''''''. .oXMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMNk' ..........xWNx'..''''''''''''''''''''''''''''''''''....,cox0NWMMMMMMMMMMMWWMMW0o,...................oNWO,.''''''...,kNMMMMMMMMMMMMMM
MMMMMMMMMMMMMK:...........'kWNo..''''''''''''''''''''''''''''''''''...  .:clodxO0KXNWWWMMMMMMNx:.......................cXM0;..''''''. .cKMMMMMMMMMMMMM
MMMMMMMMMMMWk' ..........'OWXl..''''''''''''''''''''''''''''''''''''''.............':dKWMWWKo,..........................:KMK;..''''''.. ,OWMMMMMMMMMMM
MMMMMMMMMMNo. ...........kWNo..''''''''''''''''''''''''''''''''''''''''''''''....,cx0NMMNk:..............................:XM0,.''''''''. .dNMMMMMMMMMM
MMMMMMMMMXc.............dWWd..''''''''''''''''''''''''''''''''''''''''''.....,cd0NMMMW0o,  ...............................cNMk'.''''''''...lXMMMMMMMMM
MMMMMMMMK;.............cNMk..''''''''''''''''''''''''''''''''''''''''...':dk0NWMMMMMMNOocc:;;,'''.....   ..................dWWo..''''''''.. :KMMMMMMMM
MMMMMMM0; ............'0MK;..''''''''''''''''''''''''''''''''''''....,lkXWMMMMMMMMMMMMMMMMMWWNNXXKOd;.  .................. '0MK;.'''''''''.. :KMMMMMMM
MMMMMMK; .............oWWd..''''''''''''''''''''''''''''''''''...':d0NWMMMWWMMMMMMMMMMMMMMMMMMMWKd;........................ lNWd..''''''''''. :KMMMMMM
MMMMMK: .............,0MK,.'''''''''''''''''''''''''''''''....,lkKNWNNNXXK00KNMMMMMMMMMMMMMMWKx:............................'OM0,.'''''''''''. :XMMMMM
MMMMNc ..............lNMx..'''''''''''''''''''''''''''''..   ':c::;,,,'..,ldkNMMMMMMMMMMMWXx:................................oWNc..'''''''''''..lNMMMM
MMMWd................xMNc .'''''''''''''''''''''''''''............... .,o0NWMMMMMMMMMMWKx:'................................. :XMx..'''''''''''. .dWMMM
MMMk. ...............OMK;.''''''''''''''''''''''''''''''''''''''''..'ckNWMMMMMMMMMMWKd:..................................... '0MO..''''''''''''. 'OMMM
MMX; .............. ,KM0,.'''''''''''''''''''''''''''''''''''''...:xXWWWWMMMMMMMW0d;.  .......................................OMK,.'''''''''''''. cNMM
MWd................ ;XMO'.''''''''''''''''''''''''''''''''''...;dKWMMMMMMMMMMMMNOl:;;::::cccclllc'   .........................kMK;.'''''''''''''...xWM
MK, ............... :NMO'.'''''''''''''''''''''''''''''''...,o0NMMMMMMMMMMMMMMMWWWWWWMMMMMMMMNOl,.............................kMK;.''''''''''''''. ;XM
Wd................. ;XM0,.''''''''''''''''''''''''''','..'ckXWWWMMMMMMMMMMMMMMMMMMMMMMWMMWNOo,................................kMK,.'''''''''''''''..xM
X; ................ ;XMX;.''''''''''''''''''''''''''...;xKWMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOl,..................................'OM0'.'''''''''''''''. :N
k.................. ,KMNc..''''''''''''''''''''''....;dO0OOkxdooloOWMMMMMMMMMMMMMMMWXxc'.................................... ;KMk..'''''''''''''''. '0
o ...................OMMx..'''''''''''''''''''''... .''......  .:kNMMMMMMMMMMMMMWKx:'....................................... cNWo..''''''''''''''''..d
: ...................xWWK,.''''''''''''''''''''''''''''''''..'o0WMMMMMMMMMMWMN0o;............................................xWX;..''''''''''''''''. c
, .................. cXKXo..''''''''''''''''''''''''''''...;xXWMMMMMMMMMMWX0kl,....'''''''..   ............................ ;XMk..'''''''''''''''''. ;
' .................. ,0xx0;.''''''''''''''''''''''''''...cONMMMMMMMMMMMMMWNXXXXXXXXXXXK0dc'  ...............................xWX:..'''''''''''''''''. '
. .................. .dOl0x..''''''''''''''''''''''...'oKWMMMMMMMMMMMMMMMMMMMMMMMMWXOd:,.................................. cNWd..''''''''''''''''''. .
. ................... ,0doKl..''''''''''''''''''''..,dXWMWWNXNWMMMMMMMMMMMMMMMWXOd:'..................................... ,0MO'.'''''''''''''''''''. .
. ...................  c0ldK:..''''''''''''''''..  .:lcc:;,',xNMMMMMMMMMMWNKOd:'.........................................'OWK;..'''''''''''''''''''. .
' ...................  .dOcd0:..''''''''''''''............ .oNMMMMMMMWN0dc'..............................................kWNc..''''''''''''''''''''. '
, ....................  .xk:dO:..'''''''''''''''''''''''...dNMMMMMMNOl,.  .............................................'kWWo..'''''''''''''''''''''. ,
; ....................   .kO:lOc..'''''''''''''''''''''...kWMMMMMMMWX0Okdl,.    ......................................,OWWx..''''''''''''''''''''''. c
l ....................    .kKc:kd...''''''''''''''''''..,OWMMMMMMMMMWXOdc;...........................................:KWMO'.'''''''''''''''''''''''..d
k. ....................   .,OXl,dk,..''''''''''''''''..;0MMMMMMMN0xl:'..............................................dNXXX:..''''''''''''''''''''''. .O
K; ....................   ',;0No.lx'...'''''''''''''..:KMMMMNOo:,.................................................:0W0kKd..'''''''''''''''''''''''. :X
Wo .....................  .c,;KK,.od:c,..''''''''''..cXMMMMMNOl;. ..............................................;kNW0xK0'.''''''''''''''''''''''''..dW
M0' .....................  :l.oX; :kcxKo'..'''''''..:XMMMMWX0xo:.   ..........................................;kNMWkoKNl .'''''''''''''''''''''''. ,KM
MWo .....................  .l':O; ;x,oMMXd;..''''..;KWXOxl;'................................................:kNMMMO:oX0, .'''''''''''''''''''''''..dWM
MMK, ....................  .c,;d..lc'OMMMWNkc'... .:o;'..................................................,o0WMMMMNc'cxk..'''''''''''''''''''''''. ;KMM
MMWx...................... .;':c.co.cNMMMMMWWKd:.   ..................................................,lkNMMMMMMMK,':lo..'''''''''''''''''''''''..kMMM
MMMNl....................  .;';''x: :XMMMMMMMMMWKxc,...............................................;oONMMMMMMMMWM0',l:c..''''''''''''''''''''''..oWMMM
MMMMX: ..................  :l':,.xd. :0WMMMMMMMMMMMN0xc;'.....................................':lxKWMMMMMMMMMMMMMk.:d:c'.'''''''''''''''''''''. :XMMMM
MMMMM0, .................  ox.co..lo, .l0WMMMMMMMMMMMMMWXOxl:;'.........................';:lx0XWMMMMMMMMMMMMMMMMX:.xo:o..''''''''''''''''''''..;KMMMMM
MMMMMWO' ................. ;k:.dd. .'.  .;dk0000OOOOOO00KNWMMWX0Oxdlcc;.     .,:cllodkOOkkxollcccccldkKNWMWMMMNkc:lllx: .'''''''''''''''''''..,0MMMMMM
MMMMMWWO' ................. ;d:'ok:.        ...        ...,:ox0NWMMMMMWXd. .;ONWMMWNOo;'.             ..;codol,..;clo, .'''''''''''''''''''..,0WMMMMMM
MMMMMMMWO' ................. .cl::l:.                         .':d0NMMMMWo;d0MMMMXd'                             .'....'''''''''''''''''''..,0WMMMMMMM
MMMMMMMMM0, .................. .,;,'.                             .,lkNMMXKNWMMMO,                  ...',,,;'    ....''''''''''''''''''''..:KMMMMMMMMM
MMMMMMMMMMKc.....................      'l' .'  .      ...........':;..xMMMMMMMMM0c,,,;;;;::cllodxkOO00xlc:,'.   .'''''''''''''''''''''''..lXMMMMMMMMMM
MMMMMMMMMMMNd......................    ..  ;;.;;.;' :O000000KKKKKNMK,.kWMMMMMMMMMMWWWWWWWMMMMMMMMMMMMW0d, ...c, .'''''''''''''''''''''...xNMMMMMMMMMMM
MMMMMMMMMMMMWO,....................   .;.     .. .:lkNMMMMMMMMMMMMMNc,KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWo.ld;kc..''''''''''''''''''''..;0WMMMMMMMMMMMM
MMMMMMMMMMMMMMXo. .................   lK; ,c.'d,.dWMMMMMMMMMMMMMMMMWKOddXMMMNOKMMMMMMMMMMMMMMMMMMMMMMMMN:,0ock,.'''''''''''''''''''...dXMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWO;..................  .xd..o;.c;.kWMMMMMMMMMMMMMMMMMMK; oWX0c.xMMMMMMMMMMMMMMMMMMMMMWMMk'o0;cc..''''''''''''''''''..:0WMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMNx'.................. .:, .;... .xXWMMMMMMMMMMMMMMMMk. '0d...dMMMMMMMMMMMMMMMMMMMMMMNO,'xc ...''''''''''''''''...;kNMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMXd'...................          .;co0WMMMMMMMMMMMWo  .dc   :XMMMMMMMMMWXOoccllollc,.  .  ..''''''''''''''''..,xNMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMWXd'...........................   .,:odddOWMMMMMNl  .dc   .oNMMMMMN0xc'  .;.        ....''''''''''''''''..,xNMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMWWXx,..........................  lx..:: ,KMMMMMMXc ,0k:..'dXMMMMMN0kxo. lx..'''..'''''''''''''''''''...;xNMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMNk:......................... lO' oK;.dMMMMMMMNO0WWN00NMMMMMMMMMMMX;.;'.'''''''''''''''''''''''..'cONWWMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;. ......................:.:xkl.,0MMMMMMMMMMMMMMMMMMMMMMMXxdo,. ..''''''''''''''''''''...;dKWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOl,....................  .k0;..'oXMWNKNMMMMMMMMMMMMMMMNkc. cO; .''''''''''''''''''...;o0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOo;.................. .OX; ;0d:oc:,'coo0WMXOx0NNxll,,xl.kX; .''''''''''''''...':o0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxc,.............. .co. ;XO..oKo..::,;::od:;;ll. oWl.oc...''''''''''...';lxKWMMMMMWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0dc,............    '0K,;XMx.lWN: .lWMK;'0Nc.xN:  ...''''''....';lx0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKkoc;'...........lk';XWl.xMN:..dMMNc;KWo.:d. .'''.....,;cokKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOxoc;,'... .. .:c. 'dx'  'dxc..:l'    ...,;:cox0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0Oxoc:;,'.....'........',;:clodxO0XNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWMMMWNKKKKKKKK000000000KXXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                   
";
            Console.WriteLine(Youwin);
            ReadKey();
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
            var character = _repo.GetCharacter();
            WriteLine("Its dark and dingy and smells bad. \n" +
                "What would you like to do?\n" +
                "1. Look around the bathroom \n" +
                "2. Talk to someone in the bathroom \n" +
                "3. Search the trash can\n" +
                "4. Back");

            string userinput = ReadLine().ToLower();

            switch (userinput)
            {
                case "1":
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
                case "4":
                    ExplorationMenu();
                    break;
                default:
                    WriteLine("The bathroom is a weird place man...");
                    break;
            }
        }

        private void EastEntrance() //normal security gate, ticket guard to interact w/, (guard could stop you)
        {


            var character = _repo.GetCharacter();

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
                    Console.ReadLine();

                    while (character.HasAllThreeItems == true || character.HasTicket == true)
                        if (character.HasAllThreeItems == true)
                        {

                            Console.WriteLine("'Oh, the safety inspector, come right in, Sir!'");
                            Thread.Sleep(3000);
                            YouWin();

                        }
                        else
                        {
                            character.HasTicket = true;
                            Console.WriteLine("Ah, a ticket, welcome to the show!");
                            Thread.Sleep(3000);
                            YouWin();
                        }
                    Console.WriteLine("'Get outta here! Come back when you have a ticket!");
                    Thread.Sleep(3000);
                    ExplorationMenu();
                    break;
                case "2":
                    Console.WriteLine("The overweight guard yells at you\n" +
                        "'HEY! You can't just sneak in here!\n" +
                        "He then takes a puff from an asthma inhaler and sighs");
                    Thread.Sleep(3000);
                    ExplorationMenu();
                    break;


                default:
                    WriteLine("Your code didn't run right");
                    break;
            }

        }

        private void SouthEntrance() // other concert goers, more relaxed security guy
        {
            var character = _repo.GetCharacter();

            WriteLine("You approach the venue from the south. \n" +
                "You are hopeful that this line won't be long but the security is very relaxed\n" +
                "Do you want to wait in line? y/n");

            string userinput = ReadLine().ToLower();
            switch (userinput)
            {
                case "y":
                    WriteLine("You join the line at the back.");

                    bool isWaiting = true;
                    do
                    {
                        Thread.Sleep(2500);
                        WriteLine("Do you want to keep on waiting? y/n");
                        string userinput2 = ReadLine().ToLower();
                        if (userinput2 == "n")
                        {
                            ExplorationMenu();
                        }

                    } while (isWaiting == true);
                    break;
                case "n":
                    WriteLine("You leave the south entrance");
                    Thread.Sleep(2000);
                    ExplorationMenu();
                    break;
                default:
                    WriteLine("Please enter a valid selection");
                    break;
            }
        }

        private void PressEntrance()  //locked enterance, road-crew guy (gives hard hard, asks what band we like more and gives hard hat)
        {
            var character = (_repo.GetCharacter());

            WriteLine("You approach the press entrance however the gate is locked \n" +
                "There is a stagehand by the door \n" +
                "Do you wish to talk to him y/n?");
            string userinput = ReadLine().ToLower();
            switch (userinput)
            {
                case "y":

                    Console.WriteLine("'Hey kid, do you know who the Dan is in Steely Dan?'");
                    string userinput2 = ReadLine().ToLower();
                    if (userinput2 == "walter becker")
                    {
                        WriteLine("Here, take this vest");
                        WriteLine("He throws you a reflective vest");
                        Thread.Sleep(2500);
                        character.HasVest = true;
                    }
                    if (userinput2 == "donald fagen")
                    {
                        WriteLine("'Here, take this vest'\n");
                        WriteLine("He throws you a reflective vest");
                        Thread.Sleep(2500);
                        character.HasVest = true;
                    }

                    else
                    {
                        Console.WriteLine("There's no Dan in Steely Dan\n" +
                            "Not much of a Steely Dan fan are we?");
                        Thread.Sleep(2000);
                        ExplorationMenu();
                    }
                    break;
                case "n":
                    WriteLine("Back to the drawing board");
                    ExplorationMenu();
                    break;
                default:
                    WriteLine("Please enter a valid selection");
                    break;
            }

        }

        private void ParkingLotC()  //grilled cheese and fancy rocks for sale
        {
            WriteLine("You approach parking lot C and its...smelly \n" +
                "There is a booth for grilled cheese and a booth for rocks \n" +
                "Which would you like to visit?\n" +
                "Grilled Cheese Stand\n" +
                "The Rock Guy");
            string userinput = ReadLine().ToLower();
            if (userinput == "grilled cheese stand")
            {
                WriteLine("Welcome to the dollar grilled cheese booth. Would you like one? y/n");
                string userinput2 = ReadLine().ToLower();
                if (userinput2 == "y")
                {
                    WriteLine("The scary man hands you a grilled cheese and its the most delicious thing you have ever eaten");
                    Thread.Sleep(2000);
                    ExplorationMenu();
                }
                if (userinput2 == "n")
                {
                    WriteLine("You've decided its best not to eat food from random people in the parking lot");
                    Thread.Sleep(2000);
                    ExplorationMenu();
                }
                else
                {
                    WriteLine("Please input a valid selection.");
                }
            }
            if (userinput == "the rock guy")
            {
                WriteLine("'Want to hear a joke?' y/n");
                string userinput3 = ReadLine().ToLower();
                if (userinput3 == "y")
                {
                    WriteLine("'What's dumber than a box of rocks?'");
                    Thread.Sleep(500);
                    WriteLine("'The stupid hippie carrying them, now scram'");
                    Thread.Sleep(1000);
                    ExplorationMenu();


                }
                if (userinput3 == "n")
                {
                    WriteLine("'They're not rocks, they are minerals. \n" +
                        "Thanks for looking. Do you want to have a look around?' y/n");
                    bool funnyjoke = false;
                    string userinput4 = ReadLine().ToLower();

                    if (userinput4 == "y")
                    {
                        funnyjoke = true;
                    }
                    do
                    {
                        WriteLine("You are looking around at all the amazing hunks of earth this guy drove to Pittsburgh for some reason");
                        Thread.Sleep(3000);

                    } while (funnyjoke == false);
                    if (userinput4 == "n")
                    {
                        Thread.Sleep(1000);
                        ExplorationMenu();
                    }

                }
            }

        }

        private void ParkingLotB()  //band tour busses and construction vehicles (ladder)
        {

            var character = _repo.GetCharacter();
            WriteLine("You approach Parking Lot B and find the tour busses parked alongside of some construction equipment \n" +
                "Would you like to inspect the tour bus or the construction equipment?");
            string userinput = ReadLine().ToLower();
            switch (userinput)
            {
                case "tour bus":

                    break;
                case "construction equipment":
                    break;
                default:
                    WriteLine("Please enter a valid selection");
                    break;
            }


        }

        private void ParkingLotA()  //scalper guy with sketch ticket, some hippies lost dog
        {
            var character = _repo.GetCharacter();
            WriteLine("You journey into the A Lot\n" +
                "You see a man in a trench coat with a cigarette hanging out of his mouth next to a burned out van\n" +
                "and a border collie with a red handkerchief tied around it's neck\n" +
                "Which would you like to approach?");
            string userinput = ReadLine().ToLower();
            switch (userinput)
            {
                case "the man":
                    WriteLine("Hey man, I got some tickets, real cheap, you looking to buy?");
                    string userinput1 = ReadLine().ToLower();
                    if (userinput1 == "y")
                    {
                        WriteLine("He pulls out a stack of tickets from a brown paper bag\n" +
                            "He holds them out to you like a cheap deck of cards\n" +
                            "'Pick a ticket, any ticket' he says with a toothless grin\n" +
                            "Do you want to use this ticket? y/n");
                        character.HasScalpedticket = true;
                        string userinput2 = ReadLine().ToLower();
                        if (userinput2 == "y")
                        {
                            BoxOffice();
                        }
                        else
                        {
                            ExplorationMenu();
                        }
                    }
                    if (userinput1 == "n")
                        character.ScalpedTicket = false;
                    WriteLine("You decide it's best to not trust his 'merchandise'");
                        Thread.Sleep(3000);
                    ExplorationMenu();
                    break;
                case "the dog":
                    break;
                default:
                    WriteLine("Please enter a valid selection");
                        break;
            }
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
