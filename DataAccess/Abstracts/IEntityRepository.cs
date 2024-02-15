using System.Linq.Expressions;
using Entity.Concretes;

namespace DataAccess.Abstracts;

public interface IEntityRepository<TEntity, TEntityId>
    where TEntity : Entity<TEntityId>
{
    IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>>? filter = null);

    TEntity Get(Expression<Func<TEntity, bool>> filter);

    TEntity Add(TEntity entity);

    TEntity Update(TEntity entity);

    TEntity Delete(TEntity entity);
}
