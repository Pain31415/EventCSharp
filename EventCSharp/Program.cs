namespace EventCSharp
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            var filteredList = new System.Collections.Generic.List<int>();

            foreach (int element in array)
            {
                if (predicate(element))
                {
                    filteredList.Add(element);
                }
            }

            return filteredList.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine("Парні числа:");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
            Console.WriteLine("\nНепарні числа:");
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
