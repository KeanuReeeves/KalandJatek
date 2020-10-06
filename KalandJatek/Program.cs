using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatek
{
    class Program
    {
        public static List<Character> karakterek = new List<Character>();
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            Console.WriteLine("Új karakter: '1'");
            Console.WriteLine("Kör inditás: '2'");

            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                new_character();
            }
            if(Console.ReadKey().Key == ConsoleKey.D2)
            {
                game();
            }
        }

        public static void new_character()
        {
            string text;

            do
            {
                Console.Write("\nAdd meg a karakter nevét és kasztját (szóközzel elválasztva): \n " +
                    "Továbblépéshez: 'tovább'");
                text = Console.ReadLine();
                string[] st = text.Split(' ');
                var name = new Character(st[0], st[1]);
                karakterek.Add(name);
            } while (text != "tovább");
        }

        public static void game()
        {

            Console.WriteLine("s");
        }
    }
}
