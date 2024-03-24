namespace EventCSharp
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменник не може бути нулем.", nameof(denominator));

            Numerator = numerator;
            Denominator = denominator;
        }
    }

    public static class FractionExtensions
    {
        public static Fraction FindMin(this Fraction[] fractions)
        {
            Fraction minFraction = fractions[0];

            foreach (Fraction fraction in fractions)
            {
                if ((double)fraction.Numerator / fraction.Denominator < (double)minFraction.Numerator / minFraction.Denominator)
                {
                    minFraction = fraction;
                }
            }

            return minFraction;
        }

        public static Fraction FindMax(this Fraction[] fractions)
        {
            Fraction maxFraction = fractions[0];

            foreach (Fraction fraction in fractions)
            {
                if ((double)fraction.Numerator / fraction.Denominator > (double)maxFraction.Numerator / maxFraction.Denominator)
                {
                    maxFraction = fraction;
                }
            }

            return maxFraction;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction[] fractions = new Fraction[]
            {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(2, 5),
            new Fraction(5, 8),
            new Fraction(2, 3)
            };

            Fraction minFraction = fractions.FindMin();
            Fraction maxFraction = fractions.FindMax();

            Console.WriteLine($"Мінімальний дріб: {minFraction.Numerator}/{minFraction.Denominator}");
            Console.WriteLine($"Максимальний дріб: {maxFraction.Numerator}/{maxFraction.Denominator}");
        }
    }
}
