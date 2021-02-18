using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Quiet_Journey;

namespace MenuOptions
{
    public class Menu
    {
        public static void NewGame()
        {

            Quiet_Journey.Plot.Main();
        }
        public static void ContinueGame()
        {
            
        }
        public static void GameMenu()
        {

        }
        public static void Settings()
        {
            Console.WriteLine("Ну ты шо, совсем дурак ? Какие нахер настройки ты хочешь увидеть в игре которая в консоли ?");
            Console.WriteLine("Нажмите кнопку чтобы выйти из настроек");
            Plot.MainMenu();
            Console.ReadKey();

        }
        public static void Exit()
        {
            Environment.Exit(0);
        }

    }
}
