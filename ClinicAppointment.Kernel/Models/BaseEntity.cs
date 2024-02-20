namespace ClinicAppointment.Kernel.Models;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }

    public BaseEntity()
    {
        Id = Guid.NewGuid();
    }
    public BaseEntity(Guid id, DateTime created) : this()
    {
        Id = id;
        Created = created;
        LastUpdated = created;
    }

    public BaseEntity(Guid id, DateTime created, DateTime lastUpdated) : this(id, created)
    {
        LastUpdated = lastUpdated;
    }


}