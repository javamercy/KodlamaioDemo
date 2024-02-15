using Entity.Concretes;

namespace DataAccess.Abstracts;

public interface ICategoryRepository : IEntityRepository<Category, int>
{
}
