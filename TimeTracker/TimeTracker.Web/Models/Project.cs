using System;
using System.Collections.Generic;

namespace TimeTracker.Web.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public List<Booking> Bookings { get; set;}
    }
}