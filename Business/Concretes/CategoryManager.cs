using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public List<Category> GetAll()
    {
        return _categoryRepository.GetList().ToList();
    }

    public Category GetById(int id)
    {
        return _categoryRepository.Get(c => c.Id == id);
    }

    public Category Add(Category category)
    {
        return _categoryRepository.Add(category);
    }

    public Category Update(Category category)
    {
        return _categoryRepository.Update(category);
    }

    public Category Delete(Category category)
    {
        return _categoryRepository.Delete(category);
    }
}
