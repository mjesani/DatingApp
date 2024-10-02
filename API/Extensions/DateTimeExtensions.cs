using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime givenDate)
        {
            var curDate = DateTime.Now;
            var age = curDate.Year - givenDate.Year;
            if (givenDate.Date > curDate.AddYears(-age)) age--;
            return age;
        }
    }
}