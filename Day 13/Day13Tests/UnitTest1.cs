using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_13;

namespace Day13Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3 }, Program.MakeEnds(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 1, 4 }, Program.MakeEnds(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 7, 2 }, Program.MakeEnds(new int[] { 7, 4, 6, 2 }));

        }
    }
}
