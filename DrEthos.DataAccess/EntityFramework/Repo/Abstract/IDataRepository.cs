using System;
using System.Collections.Generic;
using System.Text;

namespace DrEthos.DataAccess.EntityFramework.Repo
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Guid id);
        void Add(TEntity entity);
        void Update(Guid id, TEntity entity);
        void Delete(Guid id);
    }
}
