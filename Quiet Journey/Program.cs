using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Quiet_Journey
{
    public class Player
    {
        private string name;
        private int hp;
        private int lvl;
        private int money;
        public void playerAdd (string name,int hp, int lvl,int money)
        {
            this.name = name;
            this.hp = hp;
            this.lvl = lvl;
            this.money = money;
        }
    }
    public class Weapon
    {
        private int damage;
        private bool has;
        private string name;
        private int lvl;
        private int price;
        private bool hasInventory;
        public void weaponAdd (string name,int damage, int lvl, int price,bool has)
        {
            this.damage = damage;
            this.has = has;
            this.name = name;
            this.lvl = lvl;
            this.price = price;
        }
        public void weaponPrint ()
        {
            Console.WriteLine(name);
            Console.WriteLine(damage);
            Console.WriteLine(lvl);
            Console.WriteLine(price);
            Console.WriteLine(has);
        }
        public void weaponHas (bool has)
        {
            this.has= has;
        }
        public void weaponLvlUp (int up)
        {
            lvl = lvl + up;
            damage = damage + 5;
            price = price + 15;
        }
    }
    public class npc
    {
        private string name;
        private int guild;
        public void npcAdd(string name, int guild)
        {
            this.name = name;
            this.guild = guild;
        }
        public void npcDialog ()
        {

        }
    }
    
    public class Plot
    {
        public static void Main()
        {
            Weapon sword = new Weapon();
            sword.weaponAdd("Azerot",10,1,2000,true);
            sword.weaponPrint();
            sword.weaponLvlUp(1);
            sword.weaponPrint();
            sword.weaponHas(false);
            sword.weaponPrint();
        }
    }
}
