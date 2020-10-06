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
        public static int current = 0;

        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }

        public static void menu()
        {
            Console.WriteLine("Új karakter: '1'");
            Console.WriteLine("Kör inditás: '2'");

            var bind = Console.ReadKey().Key;

            if (bind == ConsoleKey.D1)
            {
                new_character();
            }
            else if(bind == ConsoleKey.D2)
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
                if (st[0] != "tovább") 
                { 
                var name = new Character(st[0], st[1]);
                karakterek.Add(name);
                }
            } while (text != "tovább");
            menu();
        }


        public static void game()
        {
            for (int i = 0; i < karakterek.Count; i++)
            {
                Console.WriteLine("sorszám: " + i + ".\n" + karakterek[i]);
            }

            ConsoleKey bind;

            do
            {
                Console.WriteLine("Harc: '1'");
                Console.WriteLine("Heal: '2'");
                Console.WriteLine("Kilépés a menübe: '3'");
                bind = Console.ReadKey().Key;
                if (bind == ConsoleKey.D1)
                {
                    Console.Write("Add meg a cél karakter sorszámát: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Interactions.Fight(karakterek[current], karakterek[input]);
                }
                else if (bind == ConsoleKey.D2)
                {
                    Interactions.Heal(karakterek[current]);
                }
                current++;
                if(current > karakterek.Count)
                {
                    current = 0;
                }
            } while (bind != ConsoleKey.D3);
        }
    }
}
