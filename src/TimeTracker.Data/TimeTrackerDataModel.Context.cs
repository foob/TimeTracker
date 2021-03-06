﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace TimeTracker.Data
{
    public partial class TimeTrackerDataModelContainer : ObjectContext
    {
        public const string ConnectionString = "name=TimeTrackerDataModelContainer";
        public const string ContainerName = "TimeTrackerDataModelContainer";
    
        #region Constructors
    
        public TimeTrackerDataModelContainer()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public TimeTrackerDataModelContainer(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public TimeTrackerDataModelContainer(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<User> Users
        {
            get { return _users  ?? (_users = CreateObjectSet<User>("Users")); }
        }
        private ObjectSet<User> _users;
    
        public ObjectSet<Booking> Bookings
        {
            get { return _bookings  ?? (_bookings = CreateObjectSet<Booking>("Bookings")); }
        }
        private ObjectSet<Booking> _bookings;
    
        public ObjectSet<Project> Projects
        {
            get { return _projects  ?? (_projects = CreateObjectSet<Project>("Projects")); }
        }
        private ObjectSet<Project> _projects;

        #endregion
    }
}
