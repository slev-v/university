class Program {
    static void Main(string[] args) {
        double v = 1.0; // Пример значения v
        double dy, result;

        // Цикл перебора значения y от -1.5 до 1.36 с шагом 0.01
        for (double y = -1.5; y <= 1.36; y += 0.1) {
            // Проверка значения y и вычисление результата
            if (y == 0) {
                result = 0;
            } else if (y > 0 && y < 1.36) {
                result = 1 / (v + y);
            } else if (y > -1.5 && y < 0) {
                result = 1 / (v - 2 * y);
            } else {
                Console.WriteLine("Ошибка: значение y должно быть в диапазоне от -1.5 до 1.36");
                result = 0;
            }

            // Вычисление значения dy
            dy = (y > 0 && y < 1.36) ? 0.136 : 0.15;

            // Вывод результата и значения dy на экран
            Console.WriteLine("Результат при y = " + Math.Round(y, 2) + ": " + Math.Round(result, 2));
            Console.WriteLine("Значение dy при y = " + Math.Round(y, 2) + ": " + Math.Round(dy, 2));
        }
    }
}
