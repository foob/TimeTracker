using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTracker.Data
{
    [Table("Project")]
    public class Project : BaseEntity
    {
        public virtual string Number
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
