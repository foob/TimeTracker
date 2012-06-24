using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeTracker.Web.Data;
using TimeTracker.Web.Models;

namespace TimeTracker.Web.Data
{
    public class Repository : IRepository
    {
        public static Repository Default = new Repository();

        public Repository()
        {
            _projects = new List<Project>
                           {
                               new Project
                                   {
                                       Id = Guid.NewGuid(),
                                       Name = "FundGateway",
                                       Number = "xyz"
                                   },
                               new Project
                                   {
                                       Id = Guid.NewGuid(),
                                       Name = "Application Engineering",
                                       Number = "foo"
                                   },
                               new Project
                                   {
                                       Id = Guid.NewGuid(),
                                       Name = "myCRM",
                                       Number = "ew324"
                                   }
                           };
            _bookings = new List<Booking>();
        }

        private readonly List<Project> _projects;
        public IEnumerable<Project> Projects { get { return _projects; } }

        private readonly List<Booking> _bookings;
        public IEnumerable<Booking> Bookings { get { return _bookings; } }

        public void Add(Project project)
        {
            _projects.Add(project);
        }

        public Project GetProject(Guid id)
        {
            return _projects.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Project project)
        {
            var projectToSave = GetProject(project.Id);
            projectToSave.Number = project.Number;
            projectToSave.Name = project.Name;
        }

        public void Delete(Project project)
        {
            _projects.Remove(GetProject(project.Id));
        }

        public IEnumerable<Booking> GetBookingsByProject(Guid projectId)
        {
            return _bookings.Where(b => b.ProjectId == projectId);
        }

        public void Add(Booking booking)
        {
            _bookings.Add(booking);
        }

        public Booking GetBooking(Guid id)
        {
            return _bookings.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Booking booking)
        {
            var bookingToSave = GetBooking(booking.Id);

            bookingToSave.Date = booking.Date;
            bookingToSave.HoursWorked = booking.HoursWorked;
            bookingToSave.Description = booking.Description;
        }

        public void Delete(Booking booking)
        {
            _bookings.Remove(GetBooking(booking.Id));
        }
    }
}