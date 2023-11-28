using Work_9;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Primer()
        {
            int a = 0;
            int b = 0;
            int expected = 0;
            Class1 c = new Class1();
            int actual = c.MathTentakli(a, b);
            Assert.AreEqual(expected, actual);

        }
    }
}