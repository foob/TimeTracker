using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTracker.Data
{
    [Table("User")]
    public partial class User : BaseEntity
    {
        public User()
        {
            Bookings = new Collection<Booking>();
            Projects = new Collection<Project>();
        }

        public string AccountName { get; set; }

        public virtual ICollection<Booking> Bookings{ get; set; }
        public virtual ICollection<Project> Projects{ get; set; }

    }
}
