using NUnit.Framework;
using UnitTest;

namespace NUnitTest
{
    public class Tests
    { // A TestFixture attribute supports inheritance that means
        // we can apply TestFixture attribute on base class and inherit from derived Test Classes.
        [TestFixture]
        public class Addition
        {
            [Test]
            public void AddMethodTest()
            {
                Program add = new Program();
                int result = add.Add(15, 65);
                Assert.That(result, Is.EqualTo(80));
            }

            [Test]
            [TestCase(15, 35, 50)]
            [TestCase(10, 45, 55)]
            [TestCase(20, 40, 60)]
            public void AddMethodTest(int num1, int num2, int expected)
            {
                Program add = new Program();
                int result = add.Add(num1, num2);
                Assert.AreEqual(expected, result);//50,50
            }
        }
    }
}