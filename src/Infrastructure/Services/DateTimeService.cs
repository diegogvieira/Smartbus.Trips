using Smartbus.Trips.Application.Common.Interfaces;
using System;

namespace Smartbus.Trips.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
