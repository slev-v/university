class lr_2
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine());

        if ((Math.Pow(b, 2) - 4 * a * c) < 0)
        {
            Console.WriteLine("Уравнение не имеет действительных корней");
        }
        Console.ReadKey();
    }
}
