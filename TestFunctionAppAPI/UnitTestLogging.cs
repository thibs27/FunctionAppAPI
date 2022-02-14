using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionAppAPI
{
    [TestClass]
    public class UnitTestLogging
    {
        [TestMethod]
        public void TestMethodLogging()
        {
            NullLoggerTest log = new NullLoggerTest();
            StringHelper.LogMessage(log, "test message");

            Assert.AreEqual("test message", log.logInfo);
        }
    }
}
