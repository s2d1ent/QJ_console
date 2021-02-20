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
        public static void  RecordSave()
        {

        }    
        public static void NewGame()
        {
            string path = @"save.dll";
            FileInfo saveHas= new FileInfo(path);
            if (saveHas.Exists)
            {
                Console.WriteLine("У вас уже есть активное созранение. Хотите перезаписать его ?");
                Console.WriteLine("Y - да, N - нет");
                string VeryfiNewSave = Console.ReadLine();
                VeryfiNewSave = VeryfiNewSave.ToUpper();
                switch (VeryfiNewSave)
                {
                    case "Y":
                        RecordSave();
                        break;
                    case "N":
                        ContinueGame();
                        break;
                }
            } else {
                string pathNewSave = @"../../../example.cs";
                FileInfo save = new FileInfo(pathNewSave);
                save.CopyTo(path);
                Console.WriteLine("Сохранение успешно пересоздано");
            }
            
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
