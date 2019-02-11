using Day_1_SwapEnds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwapEnds_Tests
{
    [TestClass]
    public class UnitTest1
    {
        SwapEnd test = new SwapEnd();
        
        [TestMethod]
        public void TestMethod1()
        {
            int[] testArr = { 1, 2, 3, 4 };
            int[] expectedOutput = { 4, 2, 3, 1 };
            CollectionAssert.AreEqual(expectedOutput, test.SwapEnds(testArr));
        }
    }
}
