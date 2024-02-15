namespace Entity.Concretes;

public class Entity<TId>
{
    public Entity()
    {
    }

    protected Entity(TId id)
    {
        Id = id;
    }

    public TId Id { get; set; }
}
