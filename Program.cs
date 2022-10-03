using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace MonsterKampfSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonster = 1;
            Monster monster1 = new Monster();
            Monster monster2 = new Monster();
            Console.WriteLine("Wähle zwei Kämpfende Monster aus");
            monster1 = MonsterCreator.GiveMonsterValues(numberOfMonster++);
            do
            {
                monster2 = MonsterCreator.GiveMonsterValues(numberOfMonster);
                if (!(monster1.Race == monster2.Race))
                    break;
                Console.WriteLine("nutte hast falsche eingabe gemacht");

            } while (true);
            bool test = true;
            do
            {
                monster1.AttackMonster(monster2, out test);
                Console.WriteLine($"{monster1.HP}, {monster2.HP}");

            } while (test);
            Console.ReadLine();
        }

    }
}


