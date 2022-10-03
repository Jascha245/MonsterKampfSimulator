using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSimulator
{
    internal class MonsterCreator
    {
        public static Monster GiveMonsterValues(int numberOfMonster)
        {
            Monster monster = new Monster();
            float[] temp = new float[4];
            string[] temp2 = new string[4] { "HP", "AP", "DP", "S" };
            Console.WriteLine($"Give me the Name of the {numberOfMonster}. Monster (1 for Orc), (2 for Troll), (3 for Goblin)");
            ConsoleKey input;
            do
            {
                input = Console.ReadKey().Key;
                if (input == ConsoleKey.D1 || input == ConsoleKey.D2 || input == ConsoleKey.D3)
                {
                    break;
                }
                Console.WriteLine("Please just enter a number between 1 and 3");
            } while (true);

            for (int i = 0; i < monster.NumberOfValues; i++)
            {
                Console.WriteLine($"Type in the {temp2[i]} of the {numberOfMonster}. Monster");
                bool success = float.TryParse(Console.ReadLine(), out temp[i]);
                if (!success || temp[i] < 1)
                {
                    Console.WriteLine("Digga die zahl muss größer als 0 sein");
                    i--;
                }
            }

            monster.HP = temp[0];
            monster.AP = temp[1];
            monster.DP = temp[2];
            monster.S = temp[3];
            monster.Race = (Monster.MonsterType)input;
            return monster;

        }
    }
}
