using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyzemood
    {
        public string message;
        public string happy = "I am happy";
        public string sad = "I am sad";
        public Analyzemood()
        {
            // Default constructor
        }

        public Analyzemood(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Moodanalysisexc("Exception Raised: No message was passed to determine user's mood!");
            }
            this.message = message;
        }

        public string Analyze(string message)
        {
            if (this.message == happy)
            {
                return "Happy";
            }
            else if (this.message == sad)
            {
                return "Sad";
            }
            return "Happy";
        }

    }
}
