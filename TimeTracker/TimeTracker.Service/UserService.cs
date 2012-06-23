using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;
using TimeTracker.Data.TimeTracker.Data;

namespace TimeTracker.Service
{
	public class UserService : Service<User>
	{

        public UserService(TimeTrackerContext modelContainer) : base(modelContainer)
		{
			
		}
	}
}
