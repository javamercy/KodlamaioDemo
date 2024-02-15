using Business.Concretes;
using DataAccess.Concretes;

var instructorManager = new InstructorManager(new InstructorRepository());
var courseManager = new CourseManager(new CourseRepository());
var categoryManager = new CategoryManager(new CategoryRepository());


foreach (var course in courseManager.GetAll())
{
    Console.WriteLine("{0} | {1} | {2}", course.Id, course.Description, course.ImageUrl);
}

Console.WriteLine("-----------------");

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine("{0} - {1}", instructor.Id, instructor.Name);
}

Console.WriteLine("-----------------");

foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine("{0} - {1}", category.Id, category.Name);
}
