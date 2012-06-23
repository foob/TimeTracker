using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTracker.Data;

namespace TimeTracker.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity
    {
        protected readonly TimeTrackerDataModelContainer _modelContainer;

        public Service(TimeTrackerDataModelContainer modelContainer)
        {
            _modelContainer = modelContainer;
        }

        public virtual TEntity GetById(int id)
        {
            return _modelContainer.CreateObjectSet<TEntity>().FirstOrDefault(entity => entity.Id == id);
        }

        public virtual IList<TEntity> Find(Func<TEntity, bool> search)
        {
            return _modelContainer.CreateObjectSet<TEntity>().Where(search).ToList();
        }

        public virtual void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
