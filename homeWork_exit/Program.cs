using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace homeWork_exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hpUser = 100;
            int damageUser = 10;
            int healUser = 10;
            int hpDragon = 1000;
            int damageDragon = 5;
            string inputUserText;

            Console.WriteLine("Спустившись в подземелье вы видите дракона. Ваши действия: ");
            Console.WriteLine("Dm - нанести урон даракону равный 5\nHl - излечиться на 10 hp\nexit - убежать");

            bool userWantLeave = false;
            while (hpDragon >=0) 
            {
                inputUserText = Console.ReadLine();
                switch (inputUserText) 
                {
                    case "Dm":
                        hpDragon -= damageUser;
                        Console.WriteLine("Вы нанесли "+ damageUser+ " теперь у дракона  "+ hpDragon + "hp");
                        break;
                    case "Hl":
                        hpUser += healUser;
                        Console.WriteLine("Вы исцелили себя на " + healUser + " теперь у вас " + hpUser + " hp");
                        break;
                    case "exit":
                        Console.WriteLine("Вы трус");
                        userWantLeave = true;
                        break;
                    default:
                        Console.WriteLine("Вы пытаетесь что-то сделать, но поитогу ударяете сами себя");
                        hpUser -= damageUser;
                        Console.WriteLine("Теперь у вас " +hpUser+ " hp");
                        break;
                }
                if (userWantLeave == true) 
                {
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Даракон нанес вам "+damageDragon+" урона.");
                hpUser -= damageDragon;
                Console.WriteLine("Теперь у вас "+ hpUser + " hp");
                if (hpUser <= 0) 
                {
                    Console.WriteLine("О чудо ангелы помогают вам, и исцеляют вас.");
                    hpUser = 100;
                }
                Console.WriteLine("Что вы делете дальше? ");
            }
        }
    }
}
