using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringSortTest1()
        {
            string userInput = "I believe I figured it out";
            Assert.AreEqual("believe", StringSort.StringSortMethod.WordSort());
        }
    }
}
