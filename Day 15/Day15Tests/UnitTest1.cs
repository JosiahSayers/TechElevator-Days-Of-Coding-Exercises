using Day15;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day15Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Program.Has23(new int[] { 2, 5 }));
            Assert.AreEqual(true, Program.Has23(new int[] { 4, 3 }));
            Assert.AreEqual(false, Program.Has23(new int[] { 4, 5 }));
        }
    }
}
