namespace EventCSharp
{
    public static class StringExtensions
    {
        public static int CountVowels(this string str)
        {
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if ("aeiou".Contains(c))
                    count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, how are you today?";
            int vowelsCount = text.CountVowels();
            Console.WriteLine($"Кількість голосних у рядку: {vowelsCount}");
        }
    }
}