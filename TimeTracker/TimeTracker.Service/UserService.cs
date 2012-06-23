using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;

namespace TimeTracker.Service
{
	public class UserService : IService<User>
	{
		private readonly TimeTrackerDataModelContainer _modelContainer;

		public UserService(TimeTrackerDataModelContainer modelContainer)
		{
			_modelContainer = modelContainer;
		}

		public User GetById(int id)
		{
			return _modelContainer.User.FirstOrDefault(u => u.Id == id);
		}

		public IList<User> Find(Func<User, bool> search)
		{
			return _modelContainer.User.Where(search).ToList();
		}

		public void Save(User entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(User entity)
		{
			throw new NotImplementedException();
		}
	}
}
