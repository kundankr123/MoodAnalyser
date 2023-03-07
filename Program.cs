namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string mood = MoodanalyzerFactory.InvokeAnalyzeMoodMethod("I am happy");
                Console.WriteLine(mood);
            }
            catch (Moodanalysisexc ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}