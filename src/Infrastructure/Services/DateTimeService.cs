﻿using test.Application.Common.Interfaces;
using System;

namespace test.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
