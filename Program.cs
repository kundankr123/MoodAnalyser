namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Moodanalyzer moodAnalyzer = MoodanalyzerFactory.CreateMoodAnalyzerObject("I am happy");
                if (moodAnalyzer != null)
                {
                    Console.WriteLine("Original Mood: " + moodAnalyzer.AnalyzeMood());
                    MoodanalyzerFactory.ModifyMessage("I am sad now", moodAnalyzer);
                    Console.WriteLine("Modified Mood: " + moodAnalyzer.AnalyzeMood());
                }
                else
                {
                    Console.WriteLine("Failed to create MoodAnalyzer object");
                }
            }
            catch (Moodanalysisexc ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}