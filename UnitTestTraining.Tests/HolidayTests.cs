using NUnit.Framework;

namespace UnitTestTraining.Tests
{
    [TestFixture()]
    public class HolidayTests //寂寞の小水怪
    {
        private Holiday _holiday;

        [SetUp]
        public void SetUp()
        {
            _holiday = new Holiday();
        }

        [Test()]
        public void Today_Is_XMas()
        {
            ReturnShouldBe("Merry X'Mas");
        }

        [Test()]
        public void Today_Is_Not_XMas()
        {
            ReturnShouldBe("Very sad, Today is not X'Mas");
        }

        private void ReturnShouldBe(string expected)
        {
            Assert.AreEqual(expected, _holiday.SayXMas());
        }
    }
}