using System;
namespace ExamPreparation6;
class Program
{
    static void Flag()
    {
        int days = int.Parse(Console.ReadLine());
        int plunderForDay = int.Parse(Console.ReadLine());
        int expectedPlunder = int.Parse(Console.ReadLine());
        double total = 0;

        for (int i = 1; i <= days; i++)
        {
            total += plunderForDay;

            if (i % 3 == 0)
            {
                total += plunderForDay * 0.5;
            }

            if (i % 5 == 0)
            {
                total -= total * 0.3;
            }
        }

        if (total >= expectedPlunder)
        {
            Console.WriteLine($"Ahoy! {total:F2} plunder gained.");
        }
        else
        {
            double percentage = total / expectedPlunder * 100;
            Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
        }
    }

    static void Main()
    {
        Flag();
    }
}
