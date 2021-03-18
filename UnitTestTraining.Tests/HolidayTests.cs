using NUnit.Framework;
using System;

namespace UnitTestTraining.Tests
{
    [TestFixture()]
    public class HolidayTests //寂寞の小水怪
    {
        [Test()]
        public void Today_Is_XMas()
        {
            Assert.AreEqual("Merry X'Mas", new FakeHoliday().SayXMas());
        }

        [Test()]
        public void Today_Is_Not_XMas()
        {
            Assert.AreEqual("Very sad, Today is not X'Mas", new FakeHoliday().SayXMas());
        }
    }

    internal class FakeHoliday : Holiday
    {
        private DateTime _today;

        internal void SetToday(DateTime today)
        {
            _today = today;
        }

        protected override DateTime GetToday()
        {
            return _today;
        }
    }
}