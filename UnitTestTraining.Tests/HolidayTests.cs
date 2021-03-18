using NUnit.Framework;
using UnitTestTraining;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestTraining.Tests
{
    [TestFixture()]
    public class HolidayTests //寂寞の小水怪
    {
        [Test()]
        public void Today_Is_XMas()
        {
            Assert.AreEqual("Merry X'Mas", new Holiday().SayXMas());
        }

        [Test()]
        public void Today_Is_Not_XMas()
        {
            Assert.AreEqual("Very sad, Today is not X'Mas", new Holiday().SayXMas());
        }

    }
}