using Day_12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day12Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 6 }, Program.MakeLast(new int[] { 4, 5, 6 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 2 }, Program.MakeLast(new int[] { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 0, 3 }, Program.MakeLast(new int[] {3}));
        }
    }
}
