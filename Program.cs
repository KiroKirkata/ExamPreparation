using System;
using System.Collections.Generic;
using System.Linq;
namespace ExamPreparation2;
class MonsterExtermination_2_1
{
    static void Main()
    {
        int[] monsterArms = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int[] soldierAttacks = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        Queue<int> monsters = new Queue<int>(monsterArms);
        Stack<int> soldiers = new Stack<int>(soldierAttacks);

        int killedMonsters = 0;

        while (monsters.Count > 0 && soldiers.Count > 0)
        {
            int monsterArmor = monsters.Dequeue();
            int soldierDamage = soldiers.Pop();

            if (soldierDamage >= monsterArmor)
            {
                killedMonsters++;
                int remainingDamage = soldierDamage - monsterArmor;

                if (remainingDamage > 0 && soldiers.Count > 0)
                {
                    int nextAttack = soldiers.Pop() + remainingDamage;
                    soldiers.Push(nextAttack);
                }
                else if (remainingDamage > 0)
                {
                    soldiers.Push(remainingDamage);
                }
            }
            else
            {
                int reducedArmor = monsterArmor - soldierDamage;
                monsters.Enqueue(reducedArmor);
            }
        }

        if (monsters.Count == 0)
        {
            Console.WriteLine("All monsters have been killed!");
        }
        if (soldiers.Count == 0)
        {
            Console.WriteLine("The soldier has been defeated.");
        }

        Console.WriteLine($"Total monsters killed: {killedMonsters}");
    }
}
