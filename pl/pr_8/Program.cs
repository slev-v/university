class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 5 предложений: ");
        string[] sentences = new string[5];
        for (int i = 0; i < 5; i++) sentences[i] = Console.ReadLine();
        string[] unique = new string[5];

        int uniqueCount = 0;
        for (int i = 0; i < 5; i++)
        {
            if (!unique.Contains(sentences[i]))
            {
                uniqueCount++;
                unique[i] = sentences[i];
            }
        }

        if (6 - uniqueCount == 1) Console.WriteLine("Количество одинаковых предложений: 0");
        else Console.WriteLine($"Количество одинаковых предложений: {6 - uniqueCount}");
        Console.ReadKey();
    }
}
