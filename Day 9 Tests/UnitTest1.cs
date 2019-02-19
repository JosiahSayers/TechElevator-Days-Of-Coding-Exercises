using Day_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day_9_Tests
{
    [TestClass]
    public class UnitTest1
    {
        ArraySearch test = new ArraySearch();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, test.No14(new int[] { 7, 2, 3 }));
            Assert.AreEqual(false, test.No14(new int[] { 1,2,3,4 }));
            Assert.AreEqual(false, test.No14(new int[] { 2,3,4 }));

        }
    }
}
