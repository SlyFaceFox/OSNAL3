using System;
public class MainClass
{
    public static void Main()
    {
        double A, B, H;
        Console.WriteLine("Минимальное число:");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Максимально число:");
        B = int.Parse(Console.ReadLine());
        Console.WriteLine("Нужное число сна:");
        H = int.Parse(Console.ReadLine());
        if (A < B)
        {
            if (H < A)
            {
                Console.WriteLine("Недосып");
            }
             else if (H > B)
            {
                Console.WriteLine("Пересып");
            }
             else
            {
                Console.WriteLine("Это нормально");
            }

            
        }
        else
        {
            Console.WriteLine("Данные неверные");
        }
        
    }

}

