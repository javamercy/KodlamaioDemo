using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseManager(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public List<Course> GetAll()
    {
        return _courseRepository.GetList().ToList();
    }

    public Course GetById(int id)
    {
        return _courseRepository.Get(c => c.Id == id);
    }

    public List<Course> GetByInstructorId(int id)
    {
        return _courseRepository.GetList(c => c.InstructorId == id).ToList();
    }

    public List<Course> GetByCategoryId(int id)
    {
        return _courseRepository.GetList(c => c.CategoryId == id).ToList();
    }

    public Course Add(Course course)
    {
        return _courseRepository.Add(course);
    }

    public Course Update(Course course)
    {
        return _courseRepository.Update(course);
    }

    public Course Delete(Course course)
    {
        return _courseRepository.Delete(course);
    }
}
