using System;

namespace UnitTestTraining
{
    public class Holiday //寂寞の小水怪
    {
        public string SayXMas()
        {
            var today = GetToday();
            if (today.Month.Equals(12) && today.Day.Equals(25))
            {
                return "Merry X'Mas";
            }

            return "Very sad, Today is not X'Mas";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Now;
        }
    }

}