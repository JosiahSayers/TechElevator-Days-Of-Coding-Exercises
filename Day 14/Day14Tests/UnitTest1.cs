using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day14;

namespace Day14Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Program.LessBy10(1, 7, 11), "Test1");
            Assert.AreEqual(false, Program.LessBy10(1, 7, 10), "Test2");
            Assert.AreEqual(true, Program.LessBy10(11, 1, 7), "Test3");

        }
    }
}
