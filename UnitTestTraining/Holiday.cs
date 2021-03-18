using System;

namespace UnitTestTraining
{
    public class Holiday //寂寞の小水怪
    {
        public string SayXMas()
        {
            if (DateTime.Now.Month.Equals(12) && DateTime.Now.Day.Equals(25))
            {
                return "Merry X'Mas";
            }

            return "Very sad, Today is not X'Mas";
        }
    }
}