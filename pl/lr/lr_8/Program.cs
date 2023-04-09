class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(2, 3);
        Fraction f2 = new Fraction(3, 4);

        Fraction sum = f1.Add(f2);
        Fraction difference = f1.Subtract(f2);
        Fraction product = f1.Multiply(f2);
        Fraction quotient = f1.Divide(f2);

        Console.WriteLine("f1: " + f1);
        Console.WriteLine("f2: " + f2);
        Console.WriteLine("сумма: " + sum);
        Console.WriteLine("разница: " + difference);
        Console.WriteLine("произведение: " + product);
        Console.WriteLine("частное: " + quotient);
    }

    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator - other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = this.numerator * other.numerator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator;
            int newDenominator = this.denominator * other.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}
