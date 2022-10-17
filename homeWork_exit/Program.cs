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

            int hpPlayer = 100;
            int damagePalyer = 10;
            int healPalyer = 10;
            int hpDragon = 1000;
            int damageDragon = 5;
            string inputUserText;
            bool isExit = false;

            Console.WriteLine("Спустившись в подземелье вы видите дракона. Ваши действия: ");
            Console.WriteLine($"{CommandDamage} - нанести урон даракону равный {damageDragon}\n" +
                $"{CommandHeal} - излечиться на {healPalyer} hp\n" +
                $"{CommandExit} - убежать");

            while (hpDragon >= 0) 
            {
                inputUserText = Console.ReadLine();

                switch (inputUserText) 
                {
                    case CommandDamage:
                        hpDragon -= damagePalyer;
                        Console.WriteLine($"Вы нанесли {damagePalyer} теперь у дракона {hpDragon} hp");
                        break;
                    case CommandHeal:
                        hpPlayer += healPalyer;
                        Console.WriteLine($"Вы исцелили себя на { healPalyer} теперь у вас {hpPlayer} hp");
                        break;
                    case CommandExit:
                        Console.WriteLine("Вы трус");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Вы пытаетесь что-то сделать, но поитогу ударяете сами себя");
                        hpPlayer -= damagePalyer;
                        Console.WriteLine($"Теперь у вас {hpPlayer} hp");
                        break;
                }

                if (isExit == true) 
                {
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine($"Дракон нанес вам {damageDragon} урона.");
                hpPlayer -= damageDragon;
                Console.WriteLine($"Теперь у вас {hpPlayer} hp");

                if (hpPlayer <= 0) 
                {
                    Console.WriteLine("О чудо ангелы помогают вам, и исцеляют вас.");
                    hpPlayer = 100;
                }

                Console.WriteLine("Что вы делете дальше? ");
            }
        }
    }
}
