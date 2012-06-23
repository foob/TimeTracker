using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using TimeTracker.Data;

namespace TimeTracker.Service.Test
{
    public class ModelContainerMock : ITimeTrackerDataModelContainer
    {
        public ObjectSet<User> Users
        {
            get { throw new NotImplementedException(); }
        }

        public ObjectSet<Project> Projects
        {
            get { throw new NotImplementedException(); }
        }

        public ObjectSet<Booking> Bookings
        {
            get { throw new NotImplementedException(); }
        }

        public void AddToUsers(User user)
        {
            throw new NotImplementedException();
        }

        public void AddToProjects(Project project)
        {
            throw new NotImplementedException();
        }

        public void AddToBookings(Booking booking)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges(bool acceptChangesDuringSave)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges(SaveOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
