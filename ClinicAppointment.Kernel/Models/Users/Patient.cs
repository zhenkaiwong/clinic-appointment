namespace ClinicAppointment.Kernel.Models.Users;

public class Patient : BasePerson
{
    public List<Appointment> Appointments { get; set; } = new();

    public List<Bill> Bills { get; set; } = new();
    public Patient(string name) : base(name)
    {
    }
}
