namespace EventCSharp
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"{num1} парне? {num1.IsEven()}");
            Console.WriteLine($"{num2} парне? {num2.IsEven()}");
        }
    }
}
