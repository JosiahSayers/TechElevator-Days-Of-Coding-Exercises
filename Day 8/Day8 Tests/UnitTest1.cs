using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day8;

namespace Day8_Tests
{
    [TestClass]
    public class UnitTest1
    {
        TestClass test = new TestClass();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, test.No23(new int[] { 4, 5 }));
            Assert.AreEqual(false, test.No23(new int[] { 4, 2 }));
            Assert.AreEqual(false, test.No23(new int[] { 3, 5 }));

        }
    }
}
