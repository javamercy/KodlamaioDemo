using Entity.Concretes;

namespace Business.Abstracts;

public interface ICourseService
{
    List<Course> GetAll();
    Course GetById(int id);
    List<Course> GetByInstructorId(int id);
    List<Course> GetByCategoryId(int id);
    Course Add(Course course);
    Course Update(Course course);
    Course Delete(Course course);
}
