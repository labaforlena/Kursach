using System.Collections.Generic;

namespace hashtables
{
    internal class User
    {
        public string login;
        public string password;
        public int money;
        public int exp;
        public int stamina;
        public int level;
        public int atack;
        public int def;
        public List<Item> itemsInHand;
        public List<Item> itemsInBag;
        public bool attackFort;
        public int maxStamina;
        public bool fort;

        public int countAttack()
        {
            foreach(Item i in itemsInHand)
            {
                atack += i.attack;
            }
            return atack;
        }

        public int countDef()
        {
            foreach (Item i in itemsInHand)
            {
                def += i.def;
            }
            return def;
        }

    }

    class Item
    {
        public int id;
        public int attack;
        public int def;
        public string name;
        public int value;

        
    }
}