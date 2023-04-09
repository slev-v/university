using System.Text;
class lr_7
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string st = Console.ReadLine();
        string[] words = st.Split(' ');

        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            if (word != "hello")
            {
                result.Append(word);
                result.Append(' ');
            }
        }

        Console.WriteLine(result.ToString());
        Console.ReadKey();
    }
}
