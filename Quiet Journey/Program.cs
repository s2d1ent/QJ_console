using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using SaveExample;
//using Save;
using War;


namespace Quiet_Journey
{   
    
    public class Player
    {
        private string name;
        private int hp;
        private int lvl;
        public int money;
        public void playerAdd (string name,int hp, int lvl,int money)
        {
            this.name = name;
            this.hp = hp;
            this.lvl = lvl;
            this.money = money;
        }
    }
    public class Enemy
    {
        private string name;
        private int hp;
        private int damage;
        public void enemyAdd (string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
        }
    }
    public class Weapon
    {
        private int damage;
//        private bool has;
        private string name;
        private int lvl;
        public int price;
 //       public bool hasInventory;
        public void weaponAdd (string name,int damage, int lvl, int price)
        {
            this.damage = damage;
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
        }
/*        public void weaponHas (bool has)
        {
            this.has= has;
        }*/
        public void weaponLvlUp ()
        {
            lvl++;
            damage = damage + 5;
            
            if (lvl<=5) {
                price = price + (damage * 2) + (price / 5);
            }
            if (lvl>5 && lvl<=10)
            {
                price = price + (damage * 2) + (price / 4);
            }
            if (lvl>10 && lvl<=20)
            {
                price = price + (damage * 2) + (price / 3) - 133;
            }
            if (lvl>20) {
                price = price + (damage * 2) + (price / 3);
            }
        }
        public void weaponLvlUp(int up)
        {
            lvl=lvl+up;
            damage = damage + (5*up);

            if (lvl <= 5)
            {
                price = price + (damage * 2) + (price / 5);
            }
            if (lvl > 5 && lvl <= 10)
            {
                price = price + (damage * 2) + (price / 4);
            }
            if (lvl > 10 && lvl <= 20)
            {
                price = price + (damage * 2) + (price / 3) - 133;
            }
            if (lvl > 20)
            {
                price = price + (damage * 2) + (price / 3);
            }
        }
        public void weaponPrice ()
        {
            Console.WriteLine(price);
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
    public class Shop
    {
        private int itemPrice;

    }
    public class Plot
    {
        public int hp;
        public int lvl;
        public int money;

        public bool location1 = false;
        public bool location2 = false;
        public bool location3 = false;

        public int[] helth = new int[5];
        public int helthCount;

        public Weapon slot1;
        public Weapon slot2;
        public Weapon slot3;
        public Weapon slot4;
        public int slot5;

        

        public static void NewGame ()
        {

            Main();
        }
        public static void ContinueGame ()
        {
            MainWar test = new MainWar();
            test.War();
        }
        public static void MainMenu()
        {
            Console.WriteLine("Добро пожаловать в игру!");
            Console.WriteLine("1 - Новая игра" + "\n" +
                "2 - Продолжить" + "\n" +
                "3 - Настройки" + "\n" +
                "4 - Выйти");
            int menu = int.Parse(Console.ReadLine());
            if (menu > 4)
            {
                Console.WriteLine("Введен некорректный номер интерфейса");
                while (menu > 4)
                {
                    menu = int.Parse(Console.ReadLine());
                }
            }
            switch (menu)
            {
                case 1: NewGame(); break;
                case 2: ContinueGame(); break;
                case 3: Settings(); break;
                case 4: Exit(); break;
            }
        }
        public static void Settings()
        {

        }
        public static void Exit()
        {
            Environment.Exit(0);
        }
        public static void Menu ()
        {
            
        }
        public static void Main()
        {
            
            MainMenu();





            Console.ReadKey();
        }
    }
}
