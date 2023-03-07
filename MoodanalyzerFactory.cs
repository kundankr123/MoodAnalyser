using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodanalyzerFactory
    {
        public static Analyzemood CreateMoodAnalyzer()
        {
            try
            {
                Type type = Type.GetType("Day21Reflections.AnalyzeMood");
                Analyzemood moodAnalyzer = (Analyzemood)Activator.CreateInstance(type);
                return moodAnalyzer;
            }
            catch (ArgumentNullException)
            {
                throw new Moodanalysisexc("Exception Raised: Class not found!");
            }
            catch (Exception)
            {
                throw new Moodanalysisexc("Exception Raised: Constructor is not found!");
            }
        }
    }
}
