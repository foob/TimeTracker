using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;

namespace TimeTracker.Service
{
    public class BookingService : IService<Booking>
    {
        private readonly TimeTrackerDataModelContainer _modelContainer;

        public BookingService(TimeTrackerDataModelContainer modelContainer)
        {
            _modelContainer = modelContainer;
        }


        public Booking GetById(int id)
        {
            return _modelContainer.Booking.FirstOrDefault( p => p.Id == id);
        }

        public IList<Booking> Find(Func<Booking, bool> search)
        {
            return _modelContainer.Booking.Where(search).ToList();
        }

        public void Save(Booking entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Booking entity)
        {
            throw new NotImplementedException();
        }
    }
}
