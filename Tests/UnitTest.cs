using NullConst;
using NUnit.Framework;

namespace Tests
{
    public class UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            new Program().MakeConst();
            Assert.Pass();
        }
    }
}
