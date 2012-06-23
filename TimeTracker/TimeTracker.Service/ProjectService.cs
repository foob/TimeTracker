using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;

namespace TimeTracker.Service
{
    public class ProjectService : Service<Project>
    {
        public ProjectService(TimeTrackerDataModelContainer modelContainer) : base(modelContainer) { }
    }
}
