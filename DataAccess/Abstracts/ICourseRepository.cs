using Entity.Concretes;

namespace DataAccess.Abstracts;

public interface ICourseRepository : IEntityRepository<Course, int>
{
}
