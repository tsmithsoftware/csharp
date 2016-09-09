using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Travis.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomeClassDoesSomething()
        {
            Assert.IsTrue(SomeClassToTest.DoesSomething());
        }
    }
}
