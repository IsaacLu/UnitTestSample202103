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
            Assert.AreEqual("Merry X'Mas", _holiday.SayXMas());
        }

        [Test()]
        public void Today_Is_Not_XMas()
        {
            Assert.AreEqual("Very sad, Today is not X'Mas", _holiday.SayXMas());
        }
    }
}