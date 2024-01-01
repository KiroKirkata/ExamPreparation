using System;
namespace ExamPreparation1;
class Program
{
    static void Solve()
    {
        int studentsCount = int.Parse(Console.ReadLine());
        int allLectures = int.Parse(Console.ReadLine());
        int initialBonus = int.Parse(Console.ReadLine());
        int maxAtt = 0;
        double maxBonus = 0;

        for (int i = 0; i < studentsCount; i++)
        {
            int attendances = int.Parse(Console.ReadLine());
            double bonus = (attendances / (double)allLectures) * (5 + initialBonus);

            if (bonus >= maxBonus)
            {
                maxBonus = bonus;
                maxAtt = attendances;
            }
        }

        Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
        Console.WriteLine($"The student has attended {maxAtt} lectures.");
    }

    static void Main()
    {
        Solve();
    }
}
