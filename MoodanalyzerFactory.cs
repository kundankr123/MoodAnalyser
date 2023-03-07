using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MoodAnalyser
{
    public class MoodanalyzerFactory
    {
            public static Moodanalyzer CreateMoodAnalyzerObject(string message)
            {
                Type type = Type.GetType("MoodAnalyser.Moodanalyzer");
                if (type == null)
                {
                    throw new Moodanalysisexc("Class not found");
                }
                if (!typeof(Moodanalyzer).IsAssignableFrom(type))
                {
                    throw new Moodanalysisexc("Given class does not inherit MoodAnalyzer class");
                }
                ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                object instance = constructor.Invoke(new object[] { message });
                return (Moodanalyzer)instance;
            }
    }
}
