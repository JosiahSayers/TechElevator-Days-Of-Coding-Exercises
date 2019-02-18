using Day_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day3Tests
{
    [TestClass]
    public class UnitTest1
    {
        Ticket test = new Ticket();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, test.GreenTicket(1, 2, 3));
            Assert.AreEqual(20, test.GreenTicket(2, 2, 2));
            Assert.AreEqual(10, test.GreenTicket(1, 1, 2));
        }
    }
}
