class pr_7
{
    static void Main()
    {
        Console.Write("Введите номер задания: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 1) first();
        else second();
        Console.ReadKey();
    }


    // Функия создает массив с случайными элементами и вызывает рекурсивную функцию
    static void second()
    {
        int[] arr = new int[10];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-256, 257);
            Console.Write(arr[i] + " ");
        }
        int sum = Recursion_second(arr);
        Console.WriteLine("\n" + sum);
    }


    // Рекурсивная функция для нахождения суммы положительных элементов в массиве
    static int Recursion_second(int[] arr, int index = 0)
    {
        if (index >= arr.Length) return 0;
        else
        {
            int sum = Recursion_second(arr, index + 1);
            if (arr[index] > 0) sum += arr[index];
            return sum;
        }
    }


    // Функция для приема значений и вызова рекурсивной функции
    static void first()
    {
        Console.Write("Начало прогрессии: ");
        double start = double.Parse(Console.ReadLine());
        Console.Write("Знаменатель прогрессии: ");
        double q = double.Parse(Console.ReadLine());
        Console.Write("Количество элементов прогрессии: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(Recursion_first(start, q, c));

    }

    // Рекурсивная функция для нахождения произведения геометрической прогрессии
    static double Recursion_first(double start, double q, int c)
    {
        if (c == 0) return 1;
        else
        {
            return Recursion_first(start, q, c - 1) * (start * Math.Pow(q, c - 1));
        }
    }
}
