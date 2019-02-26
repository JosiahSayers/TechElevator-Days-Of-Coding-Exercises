using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day11;

namespace Day11Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, Program.MakeMiddle(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, Program.MakeMiddle(new int[] { 7, 1, 2, 3, 4, 9 }));
            CollectionAssert.AreEqual(new int[] { 1, 2 }, Program.MakeMiddle(new int[] { 1, 2 }));
        }
    }
}
