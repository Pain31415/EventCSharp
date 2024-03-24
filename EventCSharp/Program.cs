namespace EventCSharp
{
    public static class StringExtensions
    {
        public static int CountSentences(this string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == '.' || c == '?' || c == '!')
                    count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string weatherReport = "Сьогодні у Вінниці прекрасна погода: сонячно та тепло, температура становить близько +20°C. Проте, за прогнозом, можливий короткий дощ у другій половині дня. Незважаючи на це, настрій усіх містян відмінний, адже весна вже в повному розпалі, і кожен мріє насолодитися теплим сонячним днем.";

            int sentenceCount = weatherReport.CountSentences();
            Console.WriteLine($"Кількість речень у рядку: {sentenceCount}");
        }
    }
}
