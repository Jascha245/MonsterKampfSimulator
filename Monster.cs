using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSimulator
{
    public class Monster
    {
        public enum MonsterType //Mögliche Monster
        {
            None = 0,
            Orc = ConsoleKey.D1,
            Troll = ConsoleKey.D2,
            Goblin = ConsoleKey.D3,
        }
        public float HP;   //HP der Monster
        public float AP;   //AP der Monster
        public float DP;   //DP der Monster
        public float S;    //S der Monster
        public MonsterType Race; //Rasse des Monsters
        public int NumberOfValues = 4;
        public Monster()
        {
            HP = 0f;
            AP = 0f;
            DP = 0f;
            S = 0f;
            Race = MonsterType.None;
        }
        public Monster(float hP, float aP, float dP, float s, MonsterType monster)
        {
            HP = hP;
            AP = aP;
            DP = dP;
            S = s;
            Race = monster;
        }

        public void AttackMonster(Monster monster, out bool test)
        {
            test = true;
            if (monster.S < this.S)
            {
                if ((this.AP - monster.DP) < 0)
                {
                    monster.HP -= 0;
                    return;
                }
                monster.HP -= this.AP - monster.DP;
            }
            if ((monster.AP - this.DP) < 0)
            {
                this.HP -= 0;
                return;
            }
            this.HP -= monster.AP - this.DP;
            DieMonster(monster, out test);
        }
        public void DieMonster(Monster monster, out bool test)
        {
            if (monster.HP <= 0 && this.HP <= 0)
            {
                Console.WriteLine("it's a draw!");
                test = false;
                return;
            }
            if (monster.HP <= 0)
            {
                Console.WriteLine($"{this.Race} won!");
                test = false;
                return;
            }
            if (this.HP <= 0)
            {
                test = false;
                Console.WriteLine($"{monster.Race} won!");
                return;
            }
            test = true;
        }
    }
}