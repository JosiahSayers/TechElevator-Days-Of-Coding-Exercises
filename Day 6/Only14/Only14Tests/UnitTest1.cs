using Microsoft.VisualStudio.TestTools.UnitTesting;
using Only14;

namespace Only14Tests
{
    [TestClass]
    public class UnitTest1
    {
        Only test = new Only();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, new int[] { 1, 4, 1, 4 });
            Assert.AreEqual(false, new int[] { 1, 4, 2, 5 });
            Assert.AreEqual(true, new int[] { 1, 1 });
        }
    }
}
