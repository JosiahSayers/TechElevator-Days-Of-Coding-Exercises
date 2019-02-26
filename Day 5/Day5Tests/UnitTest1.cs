using Day5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day5Tests
{
    [TestClass]
    public class UnitTest1
    {
        FizzArray test = new FizzArray();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9 }, test.FizzArray3(5, 10));
        }
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }, test.FizzArray3(11, 18));
        }
        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2 }, test.FizzArray3(1, 3));
        }
        [TestMethod]
        public void TestMethod4()
        {
            CollectionAssert.AreEqual(new int[] { }, test.FizzArray3(5, 5));

        }
    }
}
