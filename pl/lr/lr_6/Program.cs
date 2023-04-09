class lr_6
{
    static void Main()
    {
        double[] arr = new double[5];
        Console.WriteLine("Введите 5 элементов массива: ");
        for (int i = 0; i < 5; i++)
        {
            try { arr[i] = double.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Введите какое-нибудь число");
                arr[i] = double.Parse(Console.ReadLine());
            }
        }

        bool t = check(arr);
        Console.WriteLine(t);
        Console.ReadKey();
    }

    static bool check(double[] arr)
    {
        if (arr[4] == 0) return false;
        for (int i = 0; i < 4; i++)
        {
            if (!(arr[i + 1] != 0 && (arr[i] > 0 && arr[i + 1] < 0 || arr[i] < 0 && arr[i + 1] > 0)))
            {
                return false;
            }
        }
        return true;
    }
}
