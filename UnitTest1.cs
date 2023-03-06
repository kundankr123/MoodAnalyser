using MoodAnalyser;

namespace MstestMoodanalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Moodanalysisexc))]
        public void Analyze_NullMessage_ThrowsMoodAnalysisException()
        {
            //Arrange
            string message = null;

            //Act
            Analyzemood moodAnalyzer = new Analyzemood(message);


        }

        [TestMethod]
        [ExpectedException(typeof(Moodanalysisexc), "Exception Raised: No message was passed.")]
        public void Analyze_NullMessage_ThrowsMoodAnalysisExceptionWithMessage()
        {
            // Arrange
            string message = null;

            // Act and Assert
            try
            {
                Analyzemood moodAnalyzer = new Analyzemood(message);
            }
            catch (Moodanalysisexc ex)
            {
                Assert.AreEqual("Exception Raised: No message was passed.", ex.Message);
                throw;
            }
        }
    }
}