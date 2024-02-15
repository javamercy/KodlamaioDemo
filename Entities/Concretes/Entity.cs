namespace Entity.Concretes;

public class Entity<TId>
{
    public TId Id { get; set; }

    public Entity()
    {
    }

    protected Entity(TId id)
    {
        Id = id;
    }
}
