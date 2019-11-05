using NUnit.Framework;

namespace TioRACLab.DosBox.PackageTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TioRACLab.DosBox.Package.Class1.aaa();
        }
    }
}