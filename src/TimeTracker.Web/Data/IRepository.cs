using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Web.Models;

namespace TimeTracker.Web.Data
{
    public interface IRepository
    {
        IEnumerable<Project> Projects { get; }
        IEnumerable<Booking> Bookings { get; }
        void Add(Project project);
        Project GetProject(Guid id);
        void Update(Project project);
        void Delete(Project project);
        IEnumerable<Booking> GetBookingsByProject(Guid projectId);
        void Add(Booking booking);
        Booking GetBooking(Guid id);
        void Update(Booking booking);
        void Delete(Booking booking);
    }
   
}
