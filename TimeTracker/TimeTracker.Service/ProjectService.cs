using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;

namespace TimeTracker.Service
{
    public class ProjectService : IService<Project>
    {
        private readonly TimeTrackerDataModelContainer _modelContainer;

        public ProjectService(TimeTrackerDataModelContainer modelContainer)
        {
            _modelContainer = modelContainer;
        }

        public Project GetById(int id)
        {
            return _modelContainer.Project.FirstOrDefault(p => p.Id == id);
        }

        public IList<Project> Find(Func<Project, bool> search)
        {
            return _modelContainer.Project.Where(search).ToList();
        }

        public void Save(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}
