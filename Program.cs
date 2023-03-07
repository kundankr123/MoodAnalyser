namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Analyzemood mood = MoodanalyzerFactory.CreateMoodAnalyzer();
                Console.WriteLine(mood.Analyze(""));
            }
            catch (Moodanalysisexc ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}