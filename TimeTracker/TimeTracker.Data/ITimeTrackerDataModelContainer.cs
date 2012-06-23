using System.Data.Objects;

namespace TimeTracker.Data
{
    public interface ITimeTrackerDataModelContainer
    {
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        ObjectSet<User> Users { get; }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        ObjectSet<Project> Projects { get; }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        ObjectSet<Booking> Bookings { get; }

        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        void AddToUsers(User user);

        /// <summary>
        /// Deprecated Method for adding a new object to the Projects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        void AddToProjects(Project project);

        /// <summary>
        /// Deprecated Method for adding a new object to the Bookings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        void AddToBookings(Booking booking);

        int SaveChanges();
        int SaveChanges(bool acceptChangesDuringSave);
        int SaveChanges(SaveOptions options);
    }
}