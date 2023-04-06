using System;
class learning {
    static void Main()
    {
        Console.Write("Введите номер задания: ");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                double res = 0;
        
                Console.WriteLine($"{"x".PadRight(8, ' ')}Результат");
                for (double x = -6.5; x <= 12; x++)
                {
                    if (x >= -6 && x <= -4) res = -3;
                    else if (x > -4 && x <= 0) res = 0.25 * x;
                    else if (x > 0 && x <= 2) res = x * x;
                    else if (x > 2 && x <= 12) res = -0.5 * x + 5;
            
                    Console.WriteLine($"{x.ToString("F3").PadRight(8, ' ')}{res.ToString("F3")}");
                }
                break;
            case 2:
                int w = 0;
                int r1 = 5;
                int r2 = 10;

                for (int i = 0; i <= 10; i++)
                {
                    Console.Write("x = ");
                    double x2 = double.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    double y2 = double.Parse(Console.ReadLine());
                    
                    if (x2 * x2 + y2 * y2 > r1 && x2 * x2 + y2 * y2 < r2 && (x2 > 0 && y2 > 0 || x2 > 0 && y2 < 0 || x2 < 0 && y2 > 0 || x2 < 0 && y2 < 0))
                    {
                        Console.WriteLine("Попадание!!!");
                        w++;
                    }
                    else
                    {
                        Console.WriteLine("Промах!!!");
                    }
                }
                
                Console.WriteLine($"Попаданий - {w}, промахов - {10 - w}");
                break;
        }

        Console.ReadKey();
    }
}