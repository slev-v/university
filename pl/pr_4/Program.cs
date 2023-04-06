using System;
class learning {
    static void Main()
    {
        double[] arr = { 3.5, -2.7, 0, 1.2, 0, -4.1, 5.9, 0, 2.4 };

        int countZero = 0;
        double min = arr[0];
        int indexMin = 0;
        double sum = 0;

        // Подсчет количества элементов массива, равных нулю
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                countZero++;
            }
        }

        // Поиск минимального элемента и суммирование элементов после него
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
                indexMin = i;
            }

            if (i > indexMin)
            {
                sum += arr[i];
            }
        }

        Console.WriteLine($"Количество элементов, равных нулю: {countZero}");
        Console.WriteLine($"Сумма элементов, расположенных после минимального: {sum}");

        // Сортировка элементов массива по возрастанию модулей
        Array.Sort(arr, (x, y) => Math.Abs(x).CompareTo(Math.Abs(y)));

        foreach (double elem in arr)
        {
            Console.Write(elem + "; ");
        }

        Console.ReadKey();
    }
}