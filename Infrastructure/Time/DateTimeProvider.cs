﻿using SharedKernel;

namespace Infrastructure.Time
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
