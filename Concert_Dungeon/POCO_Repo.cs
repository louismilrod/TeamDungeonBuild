     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO_Directory
{
    public class POCO_Repo
    {
        public readonly List<Character> _repo = new List<Character>();
        public int _count;


        public bool AddCharacterToDirectory(Character newCharacter)   //create
        {
            if (newCharacter == null)
            {
                return false;

            }

            foreach (var user in _repo)
            {
                if (user.PlayerNameInt == newCharacter.PlayerNameInt)
                {
                    return false;
                }
            }

            //_count++;
            //newCharacter.PlayerNameInt = 1;
            _repo.Add(newCharacter);
            return true;

        }

        public Character GetCharacter()           //read
        {
            return _repo.ElementAt(0);
        }

        public Character GetCharacterByPlayerNameInt(int id)
        {
            foreach (Character item in _repo)
            {
                if (item.PlayerNameInt == id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool UpdateCharacter(int characterID, Character newCharacter) //update
        {
            Character oldCharacter = GetCharacterByPlayerNameInt(characterID);

            if (oldCharacter != null)
            {
                oldCharacter.HasClipBoard = newCharacter.HasClipBoard;
                oldCharacter.HasLadder = newCharacter.HasLadder;
                oldCharacter.HasVest = newCharacter.HasVest;
                oldCharacter.HasMoney = newCharacter.HasMoney;
                oldCharacter.HasTicket = newCharacter.HasTicket;
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
