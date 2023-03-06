namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Analyzemood mood = new Analyzemood("I am happy");
                mood.Analyze();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}