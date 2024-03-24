namespace EventCSharp
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            if (number == 2 || number == 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int divisor = 5;
            while (divisor * divisor <= number)
            {
                if (number % divisor == 0 || number % (divisor + 2) == 0)
                    return false;

                divisor += 6;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 20;

            Console.WriteLine($"{num1} є простим числом? {num1.IsPrime()}");
            Console.WriteLine($"{num2} є простим числом? {num2.IsPrime()}");
        }
    }
}
