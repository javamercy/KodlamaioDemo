namespace Entity.Concretes;

public class Instructor : Entity<int>

{
    public Instructor(int id, string name, string imageUrl) : base(id)
    {
        Name = name;
        ImageUrl = imageUrl;
    }

    public string Name { get; set; }
    public string ImageUrl { get; set; }
}
