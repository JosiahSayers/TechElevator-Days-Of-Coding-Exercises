using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day7;

namespace NoTriplesTests
{
    [TestClass]
    public class UnitTest1
    {
        Triples test = new Triples();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, test.NoTriples(new int[] { 1, 1, 2, 2, 1 }));
            Assert.AreEqual(false, test.NoTriples(new int[] { 1, 1, 2, 2, 2, 1 }));
            Assert.AreEqual(false, test.NoTriples(new int[] { 1, 1, 1, 2, 2, 2, 1 }));

        }
    }
}
