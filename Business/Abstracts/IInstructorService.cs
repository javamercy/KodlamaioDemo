using Entity.Concretes;

namespace Business.Abstracts;

public interface IInstructorService
{
    List<Instructor> GetAll();
    Instructor GetById(int id);
    Instructor Add(Instructor instructor);
    Instructor Update(Instructor instructor);
    Instructor Delete(Instructor instructor);
}
