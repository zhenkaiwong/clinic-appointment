namespace ClinicAppointment.Kernel.Models.Users;

public class Doctor : BasePerson
{
    public Dictionary<Guid, ClinicService> Services { get; set; } = new();
    public List<Appointment> Appointments { get; set; } = new();
    public Doctor(string name) : base(name)
    {
    }

    public void AddService(ClinicService service)
    {
        Services.Add(service.Id, service);
    }

    public bool TryRemoveService(ClinicService service)
    {
        return Services.Remove(service.Id);
    }
}
