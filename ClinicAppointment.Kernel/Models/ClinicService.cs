using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Models;

public class ClinicService : BaseEntity
{
    public string ServiceName { get; set; }
    public Doctor Doctor { get; set; }

    public ClinicService(string serviceName, Doctor doctor)
    {
        ServiceName = serviceName;
        Doctor = doctor;
    }
}
