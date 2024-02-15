using Entity.Concretes;

namespace Business.Abstracts;

public interface ICategoryService
{
    List<Category> GetAll();
    Category GetById(int id);
    Category Add(Category category);
    Category Update(Category category);
    Category Delete(Category category);
}
