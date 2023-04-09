class lr_1
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        double res = 2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) - 5 * x + 6;
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
