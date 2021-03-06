﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TimeTracker.Web.Models
{
    public class Booking
    {
        public static Booking Create(Guid projectId)
        {
            return new Booking
            {
                ProjectId = projectId,
                Id = Guid.NewGuid()
            };
        }
        
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Date { get; set; }
        public double HoursWorked { get; set; }
        public string Description { get; set; }
    }
}
