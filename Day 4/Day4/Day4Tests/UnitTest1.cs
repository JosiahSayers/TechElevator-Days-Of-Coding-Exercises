using Day4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Start test = new Start();

            Assert.AreEqual(2, test.Start1(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
            Assert.AreEqual(1, test.Start1(new int[] { 7, 2, 3 }, new int[] { 1 }));
            Assert.AreEqual(1, test.Start1(new int[] { 1, 2 }, new int[0]));
        }
    }
}
