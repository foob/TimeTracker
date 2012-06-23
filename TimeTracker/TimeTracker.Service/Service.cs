using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using TimeTracker.Data;
using TimeTracker.Data.TimeTracker.Data;

namespace TimeTracker.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity
    {
        protected readonly TimeTrackerContext _modelContainer;

        public Service(TimeTrackerContext modelContainer)
        {
            _modelContainer = modelContainer;
        }

        public virtual TEntity GetById(int id)
        {
            return _modelContainer.Set<TEntity>().FirstOrDefault(entity => entity.Id == id);
        }

        public virtual IList<TEntity> Find(Func<TEntity, bool> search)
        {
            return _modelContainer.Set<TEntity>().Where(search).ToList();
        }

        public virtual void Save(TEntity entity)
        {
            var set = _modelContainer.Set<TEntity>();
            set.Add(entity);
            _modelContainer.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
