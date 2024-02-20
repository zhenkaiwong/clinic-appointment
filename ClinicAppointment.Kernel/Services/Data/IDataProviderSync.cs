using ClinicAppointment.Kernel.Models;
using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Services.Data;

public interface IDataProviderSync
{
    // Doctor
    public Doctor GetDoctor(Guid id);
    public List<Doctor> GetAllDoctors();
    public Doctor InsertDoctor(Doctor doctor);
    public Doctor UpdateDoctor(Doctor doctor);
    public bool RemoveDoctor(Guid id);

    // Patient
    public Patient GetPatient(Guid id);
    public List<Patient> GetAllPatients();
    public Patient InsertPatient(Patient patient);
    public Patient UpdatePatient(Patient patient);
    public bool RemovePatient(Guid id);

    // Appointment
    public Appointment GetAppointment(Guid id);
    public List<Appointment> GetAllAppointments();
    public Appointment InsertAppointment(Appointment appointment);
    public Appointment UpdateAppointment(Appointment appointment);
    public bool RemoveAppointment(Guid id);


    // Bill
    public Bill GetBill(Guid id);
    public List<Bill> GetAllBills();
    public Bill InsertBill(Bill bill);
    public Bill UpdateBill(Bill bill);
    public bool RemoveBill(Guid id);


    // ClinicService
    public ClinicService GetClinicService(Guid id);
    public List<ClinicService> GetAllClinicServices();
    public ClinicService InsertClinicService(ClinicService clinicService);
    public ClinicService UpdateClinicService(ClinicService clinicService);
    public bool RemoveClinicService(Guid id);
}
