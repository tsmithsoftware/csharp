using NUnit.Framework;

namespace Travis.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestSomeClassDoesSomething()
        {
            Assert.IsTrue(SomeClassToTest.DoesSomething());
        }
    }
}
