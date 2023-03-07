namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Moodanalyzer moodAnalyzer = MoodanalyzerFactory.CreateMoodAnalyzerObject("I am sad");
                Console.WriteLine(moodAnalyzer.AnalyzeMood());
            }
            catch (Moodanalysisexc ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}