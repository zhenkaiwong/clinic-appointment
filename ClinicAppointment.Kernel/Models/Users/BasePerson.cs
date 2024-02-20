namespace ClinicAppointment.Kernel.Models.Users;

public abstract class BasePerson : BaseEntity
{
    public string Name { get; set; }

    public BasePerson(string name)
    {
        Name = name;
    }
}
