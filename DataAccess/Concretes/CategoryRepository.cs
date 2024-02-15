using System.Linq.Expressions;
using DataAccess.Abstracts;
using Entity.Concretes;

namespace DataAccess.Concretes;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> _categories;

    public CategoryRepository()
    {
        _categories = new List<Category>
        {
            new Category(1, "Programming"),
        };
    }

    public IEnumerable<Category> GetList(Expression<Func<Category, bool>>? filter = null)
    {
        return filter == null ? _categories : _categories.Where(filter.Compile());
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        return _categories!.FirstOrDefault(filter.Compile());
    }

    public Category Add(Category entity)
    {
        _categories.Add(entity);
        return entity;
    }

    public Category Update(Category entity)
    {
        var categoryToUpdate = _categories.FirstOrDefault(c => c.Id == entity.Id);

        if (categoryToUpdate == null) throw new Exception("Category not found");

        categoryToUpdate.Name = entity.Name;

        return categoryToUpdate;
    }

    public Category Delete(Category entity)
    {
        var categoryToDelete = _categories.FirstOrDefault(c => c.Id == entity.Id);

        if (categoryToDelete == null) throw new Exception("Category not found");

        foreach (var category in _categories)
        {
            if (category.Id == entity.Id)
                _categories.Remove(category);
        }

        return categoryToDelete;
    }
}
