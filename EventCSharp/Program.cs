namespace EventCSharp
{
    public static class StringExtensions
    {
        public static int LengthOfLastWord(this string str)
        {
            string[] words = str.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                string lastWord = words[words.Length - 1];
                return lastWord.Length;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string testString1 = "Це тестовий рядок для перевірки довжини останнього слова.";
            string testString2 = "Привіт!";

            int lengthOfLastWord1 = testString1.LengthOfLastWord();
            int lengthOfLastWord2 = testString2.LengthOfLastWord();

            Console.WriteLine($"Довжина останнього слова у першому рядку: {lengthOfLastWord1}");
            Console.WriteLine($"Довжина останнього слова у другому рядку: {lengthOfLastWord2}");
        }
    }
}
