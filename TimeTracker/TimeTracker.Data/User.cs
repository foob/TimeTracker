using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTracker.Data
{
    [Table("Booking")]
    public partial class User : BaseEntity
    {
        private ICollection<Booking> _bookings;
        private ICollection<Project> _projects;

        public virtual ICollection<Booking> Bookings
        {
            get { return _bookings; }
            set { _bookings = value; }
        }
        
    
        public virtual ICollection<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
    }
}
