using Has12_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Has12Tests
{
    [TestClass]
    public class UnitTest1
    {
        Has test = new Has();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, test.has12(new int[] { 1, 3, 2 }));
            Assert.AreEqual(true, test.has12(new int[] { 3, 1, 2 }));
            Assert.AreEqual(true, test.has12(new int[] { 3, 1, 4, 5, 2 }));
            Assert.AreEqual(false, test.has12(new int[] { 2, 3, 1 }));
            Assert.AreEqual(true, test.has12(new int[] { 2, 1, 2 }));

        }
    }
}
