using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.Service
{
    public interface IService<TEntity>
    {
        TEntity GetById();
        IList<TEntity> Find(Func<TEntity, bool> search);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}
