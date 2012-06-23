using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;
using TimeTracker.Data.TimeTracker.Data;

namespace TimeTracker.Service
{
    public class BookingService : Service<Booking>
    {

        public BookingService(TimeTrackerContext modelContainer)
            : base(modelContainer)
        {
        }

    }
}
