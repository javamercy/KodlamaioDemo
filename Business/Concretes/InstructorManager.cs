using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorRepository _instructorRepository;

    public InstructorManager(IInstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository;
    }

    public List<Instructor> GetAll()
    {
        return _instructorRepository.GetList().ToList();
    }

    public Instructor GetById(int id)
    {
        return _instructorRepository.Get(i => i.Id == id);
    }

    public Instructor Add(Instructor instructor)
    {
        return _instructorRepository.Add(instructor);
    }

    public Instructor Update(Instructor instructor)
    {
        return _instructorRepository.Update(instructor);
    }

    public Instructor Delete(Instructor instructor)
    {
        return _instructorRepository.Delete(instructor);
    }
}
