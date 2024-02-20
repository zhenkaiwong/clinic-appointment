using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Models;

public class Appointment : BaseEntity
{
    public Patient? Patient { get; set; }
    public Doctor? Doctor { get; set; }

    public List<ClinicService> ClinicServices { get; set; } = new();

    public Appointment(Patient patient, Doctor doctor, List<ClinicService> services)
    {
        Patient = patient;
        Doctor = doctor;
        ClinicServices = services;
    }
}
