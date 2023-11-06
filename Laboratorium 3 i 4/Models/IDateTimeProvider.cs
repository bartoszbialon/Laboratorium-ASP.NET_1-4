﻿namespace Laboratorium_3_i_4.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTime();
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
