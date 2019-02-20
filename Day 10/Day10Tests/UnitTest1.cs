using Day_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day10Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Day10 test = new Day10();

            Assert.AreEqual(true, test.More14(new int[] { 1, 4, 1 }));
            Assert.AreEqual(false, test.More14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(true, test.More14(new int[] { 1, 1 }));
        }
    }
}
