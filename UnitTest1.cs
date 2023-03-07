using MoodAnalyser;

namespace MstestMoodanalyser
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenHappyMessage_UsingReflection_ShouldReturnHappyMood()
        {
            // Arrange
            string message = "I am happy";
            string expectedMood = "happy";

            // Act
            string mood = MoodanalyzerFactory.InvokeAnalyzeMoodMethod(message);

            // Assert
            Assert.AreEqual(expectedMood, mood);
        }


        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrowMoodAnalysisException()
        {
            // Arrange
            string message = "I am happy";
            string methodName = "WrongMethodName";

            try
            {
                // Act
                string mood = MoodanalyzerFactory.InvokeAnalyzeMoodMethod(message);
            }
            catch (Moodanalysisexc ex)
            {
                // Assert
                Assert.AreEqual("No such method found", ex.Message);
            }
        }
    }
}