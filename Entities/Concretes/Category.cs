namespace Entity.Concretes;

public class Category : Entity<int>

{
    public Category(int id, string name) : base(id)
    {
        Name = name;
    }

    public string Name { get; set; }
}
