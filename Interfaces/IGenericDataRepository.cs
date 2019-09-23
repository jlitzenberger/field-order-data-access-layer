using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FieldOrder.DataAccessLayer.Interfaces {
    public interface IGenericDataRepository<TEntity>
        where TEntity : class {
        System.Collections.Generic.IEnumerable<TEntity> GetAll();
        void Delete(object id);
        void Delete(TEntity entity);
        System.Collections.Generic.IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, params string[] navigationProperties);
        TEntity GetSingle(Expression<Func<TEntity, bool>> predicate);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
