using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace TimeTracker.Service
{
    public interface IService<TEntity> where TEntity : EntityObject
    {
        TEntity GetById(int id);
        IList<TEntity> Find(Func<TEntity, bool> search);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}
