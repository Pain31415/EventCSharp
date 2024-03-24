namespace EventCSharp
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            string[] words = str.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Це тестовий рядок для перевірки кількості слів у ньому.";

            int wordCount = testString.WordCount();

            Console.WriteLine($"Кількість слів у рядку: {wordCount}");
        }
    }
}
