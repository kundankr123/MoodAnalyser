using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Moodanalyzer
    {
        public string message;
        public string happy = "I am happy";
        public string sad = "I am sad";

        public Moodanalyzer()
        {

        }

        public Moodanalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            if (string.IsNullOrEmpty(this.message))
            {
                throw new Moodanalysisexc("Exception Raised: No message was passed to determine user's mood!");
            }
            else if (this.message.Contains("happy"))
            {
                return "happy";
            }
            else if (this.message.Contains("sad"))
            {
                return "sad";
            }
            return "";
        }
    }
}
