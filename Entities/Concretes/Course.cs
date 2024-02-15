namespace Entity.Concretes;

public class Course : Entity<int>
{
    public Course()
    {
    }

    public Course(int id, int instructorId, string description,
        string imageUrl, int categoryId) : base(id)
    {
        Description = description;
        ImageUrl = imageUrl;
        CategoryId = categoryId;
        InstructorId = instructorId;
    }


    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
}
