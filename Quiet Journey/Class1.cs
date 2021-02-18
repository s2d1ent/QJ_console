using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Тестирование элементов
//Реализации разных штук
//
//
//
//
//

namespace War
{
    public class Player
    {
        private string name;
        private int hp;
        private int lvl;
        public int money;
        public void playerAdd(string name, int hp, int lvl, int money)
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
        public void enemyAdd(string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
        }
        public void enemyName ()
        {
            Console.Write(this.name);
        }
    }
    public class Weapon
    {
        private int damage;
        private string name;
        private int lvl;
        public int price;
        public void weaponAdd(string name, int damage, int lvl, int price)
        {
            this.damage = damage;
            this.name = name;
            this.lvl = lvl;
            this.price = price;
        }
        public void weaponPrint()
        {
            Console.WriteLine(name);
            Console.WriteLine(damage);
            Console.WriteLine(lvl);
            Console.WriteLine(price);
        }
       
    }
    public class MainWar {
        public bool war = true;
        Player player = new Player();
        Weapon sword = new Weapon();
        Enemy enemy = new Enemy();

      
        public int hpPlayer = 100;
        public  int moneyPlayer = 200;
        public  int lvlPlayer = 1;

        public int weaponDamage = 10;
        public int weaponLvl = 1;
        public int weaponPrice = 200;

        public int hpEnemy = 100;
        public  int damageEnemy = 10;
        public bool enemyName = false;

        public bool enemyDeth = false;
        public bool death=false;

        public void Atack ()
        {
            int totalEnemyHp = hpEnemy;
            int totalPlayerHp = hpPlayer;

            const int totalEnemyDamage = 10;
            const int totalPlayerDamage = 10;
            Random rand = new Random();
           int rand1 = rand.Next(1, 3);
           int rand2 = rand.Next(1, 3);
            if (rand1==1 || rand1==2 || rand1==3)
            {
                weaponDamage = totalPlayerDamage;
                weaponDamage = weaponDamage * rand1;
                hpEnemy = hpEnemy- weaponDamage;
                Console.WriteLine("Состояние здоровья противкника " + hpEnemy + " из " + 100);
            }
            if (hpEnemy!= totalEnemyHp)
            {
                damageEnemy = totalEnemyDamage;
                damageEnemy = damageEnemy * rand2;
                hpPlayer = hpPlayer- damageEnemy;
                Console.WriteLine("Ваше состояние здоровья " + hpPlayer+ " из " + 100);
                if (hpEnemy <= 0)
                {
                    enemyDeth = true;
                    Console.WriteLine("Вы смогли одолеть ");
                    enemy.enemyName();
                } else {}
                if (hpPlayer <= 0 && hpEnemy > 0)
                {
                    enemyDeth = false;
                    death = true;
                    Console.WriteLine("Вы мертвы. Хотите начать заново ?");

                } else { }
                
            }
           
        }
        public void War ()
        {
            player.playerAdd("Name", hpPlayer, lvlPlayer, moneyPlayer);
            sword.weaponAdd("Arondit", weaponDamage, weaponLvl, weaponPrice);
            enemy.enemyAdd("Name", hpEnemy, damageEnemy);
            if (war && !enemyName)
            {
                Console.Write("Вы начали бой с ");
                enemy.enemyName();
                Console.WriteLine("\n"+"Выберите действие");
                Console.WriteLine("1 - Ударить" + "\n" +
                    "2 - Выпить зелье" + "\n" +
                    "3 - Блокировать удар");
                int selectWar = int.Parse(Console.ReadLine());
                switch (selectWar) {
                    case 1:
                        Atack();
                        break;
                    case 2:
                        break;
                    case 3  :
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
