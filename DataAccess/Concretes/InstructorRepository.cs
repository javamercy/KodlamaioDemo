using System.Linq.Expressions;
using DataAccess.Abstracts;
using Entity.Concretes;


namespace DataAccess.Concretes;

public class InstructorRepository : IInstructorRepository
{
    private readonly IList<Instructor> _instructors;

    public InstructorRepository()
    {
        _instructors = new List<Instructor>
        {
            new Instructor(1, "Engin Demiroğ", "engin.jpg"),
            new Instructor(2, "Halit Enes Kalaycı", "halit.jpg"),
        };
    }

    public IEnumerable<Instructor> GetList(Expression<Func<Instructor, bool>>? filter = null)
    {
        return filter == null ? _instructors : _instructors.Where(filter.Compile());
    }

    public Instructor Get(Expression<Func<Instructor, bool>> filter)
    {
        return _instructors!.FirstOrDefault(filter.Compile());
    }

    public Instructor Add(Instructor entity)
    {
        _instructors.Add(entity);
        return entity;
    }

    public Instructor Update(Instructor entity)
    {
        var instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == entity.Id);

        if (instructorToUpdate == null) throw new Exception("Instructor not found");

        instructorToUpdate.Name = entity.Name;
        instructorToUpdate.ImageUrl = entity.ImageUrl;
        return instructorToUpdate;
    }

    public Instructor Delete(Instructor entity)
    {
        var instructorToDelete = _instructors.FirstOrDefault(i => i.Id == entity.Id);

        if (instructorToDelete == null) throw new Exception("Instructor not found");

        foreach (var instructor in _instructors)
        {
            if (instructor.Id == entity.Id)
                _instructors.Remove(instructor);
        }

        return instructorToDelete;
    }
}
