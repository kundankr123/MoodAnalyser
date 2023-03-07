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
                throw new Moodanalysisexc("Given class does not inherit Moodanalyzer class");
            }
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
            object instance = constructor.Invoke(new object[] { message });
            return (Moodanalyzer)instance;
        }


        public static string InvokeAnalyzeMoodMethod(string message)
        {
            Moodanalyzer moodAnalyzer = CreateMoodAnalyzerObject(message);
            Type type = moodAnalyzer.GetType();
            MethodInfo analyzeMoodMethod = type.GetMethod("AnalyzeMood");
            return (string)analyzeMoodMethod.Invoke(moodAnalyzer, null);
        }

        public static void ModifyMessage(string message, Moodanalyzer moodAnalyzer)
        {
            Type type = moodAnalyzer.GetType();
            PropertyInfo propertyInfo = type.GetProperty("message");
            propertyInfo.SetValue(moodAnalyzer, message);
        }
    }
}
