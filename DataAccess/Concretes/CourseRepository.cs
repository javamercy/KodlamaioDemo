using System.Linq.Expressions;
using DataAccess.Abstracts;
using Entity.Concretes;


namespace DataAccess.Concretes;

public class CourseRepository : ICourseRepository
{
    private readonly List<Course> _courses;

    public CourseRepository()
    {
        _courses = new List<Course>
        {
            new Course()
            {
                CategoryId = 1,
                InstructorId = 1,
                Description = "Senior Yazılım Geliştirme Kampı (.NET)",
                Id = 1,
                ImageUrl = "csharp.jpg",
            },
            new Course()
            {
                CategoryId = 1,
                InstructorId = 1,
                Description = "Yazılım geliştirme Kampı (C# + ANGULAR)",
                Id = 2,
                ImageUrl = "csharp.jpg",
            },
            new Course()
            {
                CategoryId = 1,
                InstructorId = 2,
                Description = "(2023) Yazılım Geliştirme Kampı - Python & Selenium",
                Id = 3,
                ImageUrl = "python.jpg",
            },
            new Course()
            {
                CategoryId = 1,
                InstructorId = 1,
                Description = "Yazılım Geliştirme Kampı (JAVA + REACT)",
                Id = 4,
                ImageUrl = "java.jpg",
            },
            new Course()
            {
                CategoryId = 1,
                InstructorId = 1,
                Description = "Yazılım Geliştirme Kampı (JAVASCRIPT)",
                Id = 5,
                ImageUrl = "javascript.jpg",
            },

            new Course()
            {
                CategoryId = 1,
                Description = "(2022) Yazılım Geliştirme Kampı- JAVA",
                Id = 6,
                ImageUrl = "java.jpg",
            },
            new Course()
            {
                CategoryId = 1,
                Description = "(2024) Yazılım Geliştirme Kampı- C#",
                Id = 7,
                ImageUrl = "csharp.jpg",
            },
        };
    }

    public IEnumerable<Course> GetList(Expression<Func<Course, bool>>? filter = null)
    {
        return filter == null ? _courses : _courses.Where(filter.Compile()).ToList();
    }

    public Course Get(Expression<Func<Course, bool>> filter)
    {
        return _courses!.FirstOrDefault(filter.Compile());
    }

    public Course Add(Course entity)
    {
        _courses.Add(entity);
        return entity;
    }

    public Course Update(Course entity)
    {
        var courseToUpdate = _courses.FirstOrDefault(c => c.Id == entity.Id);

        if (courseToUpdate == null) throw new Exception("Course not found");

        courseToUpdate.CategoryId = entity.CategoryId;
        courseToUpdate.Description = entity.Description;
        courseToUpdate.ImageUrl = entity.ImageUrl;
        courseToUpdate.InstructorId = entity.InstructorId;

        return courseToUpdate;
    }

    public Course Delete(Course entity)
    {
        var courseToDelete = _courses.FirstOrDefault(c => c.Id == entity.Id);

        if (courseToDelete == null) throw new Exception("Course not found");

        foreach (var course in _courses)
        {
            if (course.Id == entity.Id)
                _courses.Remove(course);
        }

        return courseToDelete;
    }
}
