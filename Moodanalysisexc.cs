using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Moodanalysisexc : Exception
    {
        
            public Moodanalysisexc(string message) : base(message)
            {

            }
    }
}
