using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace The_character
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string Characteristics = "Характеристики: ";
            int Level = 1, HP = 100;


            string Name = CharacterName();

            string Class = ClassName();

            Console.WriteLine("Введите титул персонажа");
            string Title = Console.ReadLine();

            int Vitality = LevelClassEndurance(Level, Class);

            int Strength = LevelClassStrength(Level, Class);

            int Agility = LevelClassAgility(Level, Class);

            int Intellect = LevelClassIntellect(Level, Class);

            int MP = LevelClassMP(Level, Class, Vitality, Strength, Agility, Intellect);

            Console.WriteLine("\n" + "\n" + "Имя персонажа: " + Name );
            Console.WriteLine("Класс: " + Class);
            Console.WriteLine("Титул: " + Title);
            Console.WriteLine(Characteristics);
            Console.WriteLine("Живучесть " + HP + "%");
            Console.WriteLine("Выносливость/Манна: " + MP);
            Console.WriteLine("Уровень: " + Level);
            Console.WriteLine("Жизнестойкость: " + Vitality);
            Console.WriteLine("Сила: " + Strength);
            Console.WriteLine("Ловкость: " + Agility);
            Console.WriteLine("Интелект: " + Intellect);

            Console.ReadLine();
        }

        static string CharacterName()
        {
            Console.WriteLine("Введите имя персонажа");
            string Line = Console.ReadLine();
            return Line;
        }

        static string ClassName()
        {
            string Class = null;
            Console.WriteLine("Выбирите свой класс( а, б, в, г) согласно предложеных:\nа. Воин;\nб. Лучник;\nв. Маг;\nг. Целитель;");
            string n = Console.ReadLine();
            if (n == "а")
            {
                Class = "Воин";
            } else if ((n == "б"))
            {
                Class = "Лучник";
            } else if ((n == "в"))
            {
                Class = "Маг";
            } else if ((n == "г"))
            {
                Class = "Целитель";
            } 
            return Class;
        }

        static int LevelClassEndurance(int Level, string Class)
        {
            int Endurance = 0;

            if (Class == "Воин")
            {
                Endurance = 6 * Level;
            }
            else if (Class == "Лучник")
            {
                Endurance = 5 * Level;
            } 
            else if (Class == "Маг")
            {
                Endurance = 5 * Level;
            } 
            else if (Class == "Целитель")
            {
                Endurance = 5 * Level;
            }

                return Endurance;
        }

        static int LevelClassStrength(int Level, string Class)
        {
            int Strength = 0;

            if (Class == "Воин")
            {
                Strength = 6 * Level;
            }
            else if (Class == "Лучник")
            {
                Strength = 5 * Level;
            }
            else if (Class == "Маг")
            {
                Strength = 4 * Level;
            } 
            else if (Class == "Целитель")
            {
                Strength = 4 * Level;
            }

                return Strength;
        }

        static int LevelClassAgility(int Level, string Class)
        {
            int Agility = 0;

            if (Class == "Воин")
            {
                Agility = 4 * Level;
            }
            else if (Class == "Лучник")
            {
                Agility = 6 * Level;
            }
            else if (Class == "Маг")
            {
                Agility = 4 * Level;
            }
            else if (Class == "Целитель")
            {
                Agility = 4 * Level;
            }

            return Agility;
        }

        static int LevelClassIntellect(int Level, string Class)
        {
            int Intellect = 0;

            if (Class == "Воин")
            {
                Intellect = 4 * Level;
            }
            else if (Class == "Лучник")
            {
                Intellect = 4 * Level;
            }
            else if (Class == "Маг")
            {
                Intellect = 7 * Level;
            }
            else if (Class == "Целитель")
            {
                Intellect = 7 * Level;
            }

            return Intellect;
        }

        static int LevelClassMP(int Level, string Class, int V, int S, int A, int I)
        {
            int MP = 0;

            if (Class == "Воин")
            {
                MP = (V + S) * Level;
            }
            else if (Class == "Лучник")
            {
                MP = (V + A) * Level;
            }
            else if (Class == "Маг")
            {
                MP = (V + I) * Level;
            }
            else if (Class == "Целитель")
            {
                MP = (V + I) * Level;
            }

            return MP;
        }

    }
}
