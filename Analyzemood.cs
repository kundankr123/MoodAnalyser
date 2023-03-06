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


        public Analyzemood(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Moodanalysisexc("Exception Raised: No message was passed.");
            }
            this.message = message;
        }

        public void Analyze()
        {
            if (this.message == happy)
            {
                Console.WriteLine("Mood: Happy");
            }
            else if (this.message == sad)
            {
                Console.WriteLine("Mood: Sad");
            }
        }

    }
}
