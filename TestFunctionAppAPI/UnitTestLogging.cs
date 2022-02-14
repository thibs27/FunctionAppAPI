using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionApp1
{
    [TestClass]
    public class UnitTestLogging
    {
        [TestMethod]
        public void TestMethodLogging()
        {
            NullLoggerTest log = new NullLoggerTest();
            StringHelper.LogMessage(log, "test message");

            Assert.AreEqual("test message1", log.logInfo);
        }
    }
}
