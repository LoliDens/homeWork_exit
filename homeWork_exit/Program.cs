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
            const string CommandDamage = "1";
            const string CommandHeal = "2";
            const string CommandExit = "3";

            int hpUser = 100;
            int damageUser = 10;
            int healUser = 10;
            int hpDragon = 1000;
            int damageDragon = 5;
            string inputUserText;
            bool isExit = false;

            Console.WriteLine("Спустившись в подземелье вы видите дракона. Ваши действия: ");
            Console.WriteLine($"{CommandDamage} - нанести урон даракону равный {damageDragon}\n" +
                $"{CommandHeal} - излечиться на {healUser} hp\n" +
                $"{CommandExit} - убежать");

            while (hpDragon >= 0) 
            {
                inputUserText = Console.ReadLine();

                switch (inputUserText) 
                {
                    case CommandDamage:
                        hpDragon -= damageUser;
                        Console.WriteLine("Вы нанесли "+ damageUser+ " теперь у дракона  "+ hpDragon + "hp");
                        break;
                    case CommandHeal:
                        hpUser += healUser;
                        Console.WriteLine("Вы исцелили себя на " + healUser + " теперь у вас " + hpUser + " hp");
                        break;
                    case CommandExit:
                        Console.WriteLine("Вы трус");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Вы пытаетесь что-то сделать, но поитогу ударяете сами себя");
                        hpUser -= damageUser;
                        Console.WriteLine($"Теперь у вас " +hpUser+ " hp");
                        break;
                }

                if (isExit == true) 
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
