using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using SaveExample;
//using Save;
using War;
using MenuOptions;


namespace Quiet_Journey
{   
    
    public class Player
    {
        public string PlayerName;
        public int Playerhp;
        public int WeaponLvl;
        public int moneyPlayer=200;
        public int damagePlayer=10;
        public int weaponPrice = 300;
        public int[] helth = new int[5];
        public void playerAdd (string name,int hp, int lvl)
        {
            this.PlayerName = name;
            this.Playerhp = hp;
            this.WeaponLvl = lvl;
        }
        public void HelthCount (Player player)
        {
            for (int i=0;i<player.helth.Length;i++) {
 //               player.helth[i];
            };
        }
        public void WeaponLvlUp()
        {
            WeaponLvl++;
            damagePlayer = damagePlayer + 5;

            if (WeaponLvl <= 5)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 5);
            }
            if (WeaponLvl > 5 && WeaponLvl <= 10)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 4);
            }
            if (WeaponLvl > 10 && WeaponLvl <= 20)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 3) - 133;
            }
            if (WeaponLvl > 20)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 3);
            }
        }
        public void WeaponLvlUp(int up)
        {
            WeaponLvl = WeaponLvl + up;
            damagePlayer = damagePlayer + (5 * up);

            if (WeaponLvl <= 5)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 5);
            }
            if (WeaponLvl > 5 && WeaponLvl <= 10)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 4);
            }
            if (WeaponLvl > 10 && WeaponLvl <= 20)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 3) - 133;
            }
            if (WeaponLvl > 20)
            {
                weaponPrice = weaponPrice + (damagePlayer * 2) + (weaponPrice / 3);
            }
        }
        public void WeaponPrice()
        {
            Console.WriteLine(weaponPrice);
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
    public class npc
    {
        private string name;
        private int guild;
        public string[] quest = new string[10];
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

       
        public int helthCount;

        

        

           
        public static void MainMenu()
        {
            Console.WriteLine("Добро пожаловать в игру!");
            Console.WriteLine("1 - Новая игра" + "\n" +
                "2 - Продолжить" + "\n" +
                "3 - Настройки" + "\n" +
                "4 - Выйти");
            dynamic menu = Console.ReadLine();
            if (!Char.IsNumber(menu,0)) {
                while (menu > 4)
                {
                    Console.WriteLine("Введен некорректный номер интерфейса");
                    menu = Console.ReadLine();
                }
            }
            if (menu != null || menu != " " || Char.IsNumber(menu,0))
            {
                menu = int.Parse(menu);
            }
            if (menu > 4 )
            {              
                while (menu > 4)
                {
                    Console.WriteLine("Введен некорректный номер интерфейса");
                    menu = Console.ReadLine();
                }
                if (menu != null || menu != " " || Char.IsNumber(menu, 0))
                {
                    menu = int.Parse(menu);
                }
            }
            switch (menu)
            {
                case 1: Menu.NewGame(); break;
                case 2: Menu.ContinueGame(); break;
                case 3: Menu.Settings(); break;
                case 4: Menu.Exit(); break;
                default: MainMenu();break;
            }
        }
        
        public static void Main()
        {
            
            MainMenu();





            Console.ReadKey();
        }
    }
}
