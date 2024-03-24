namespace EventCSharp
{
    public static class StringExtensions
    {
        public static int CountConsonants(this string str)
        {
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c) && !"aeiou".Contains(c))
                    count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string weatherReport = "Today in Vinnytsia, the weather is lovely: sunny and warm, with temperatures around +20°C. However, according to the forecast, there is a chance of a brief shower in the afternoon. Despite this, everyone's mood is excellent as spring is in full swing, and everyone is eager to enjoy the warm sunny day.";
            int consonantsCount = weatherReport.CountConsonants();
            Console.WriteLine($"Кількість приголосних у рядку: {consonantsCount}");
        }
    }
}