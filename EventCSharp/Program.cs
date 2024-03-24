namespace EventCSharp
{
    public static class IntExtensions
    {
        public static bool IsFibonacci(this int number)
        {
            Func<int, bool> isPerfectSquare = n => Math.Sqrt(n) % 1 == 0;

            return isPerfectSquare(5 * number * number + 4) || isPerfectSquare(5 * number * number - 4);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int testNumber1 = 5;
            int testNumber2 = 8;
            int testNumber3 = 10;

            Console.WriteLine($"{testNumber1} є числом Фібоначчі: {testNumber1.IsFibonacci()}");
            Console.WriteLine($"{testNumber2} є числом Фібоначчі: {testNumber2.IsFibonacci()}");
            Console.WriteLine($"{testNumber3} є числом Фібоначчі: {testNumber3.IsFibonacci()}");
        }
    }
}
