using ClinicAppointment.Kernel.Models;
using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Services.Data;

public interface IDataProviderAsync
{
    // Doctor
    public Task<Doctor> GetDoctorAsync(Guid id);
    public Task<List<Doctor>> GetAllDoctorsAsync();
    public Task<Doctor> InsertDoctorAsync(Doctor doctor);
    public Task<Doctor> UpdateDoctorAsync(Doctor doctor);
    public Task<bool> RemoveDoctorAsync(Guid id);

    // Patient
    public Task<Patient> GetPatientAsync(Guid id);
    public Task<List<Patient>> GetAllPatientsAsync();
    public Task<Patient> InsertPatientAsync(Patient patient);
    public Task<Patient> UpdatePatientAsync(Patient patient);
    public Task<bool> RemovePatientAsync(Guid id);

    // Appointment
    public Task<Appointment> GetAppointmentAsync(Guid id);
    public Task<List<Appointment>> GetAllAppointmentsAsync();
    public Task<Appointment> InsertAppointmentAsync(Appointment appointment);
    public Task<Appointment> UpdateAppointmentAsync(Appointment appointment);
    public Task<bool> RemoveAppointmentAsync(Guid id);


    // Bill
    public Task<Bill> GetBillAsync(Guid id);
    public Task<List<Bill>> GetAllBillsAsync();
    public Task<Bill> InsertBillAsync(Bill bill);
    public Task<Bill> UpdateBillAsync(Bill bill);
    public Task<bool> RemoveBillAsync(Guid id);


    // ClinicService
    public Task<ClinicService> GetClinicServiceAsync(Guid id);
    public Task<List<ClinicService>> GetAllClinicServicesAsync();
    public Task<ClinicService> InsertClinicServiceAsync(ClinicService clinicService);
    public Task<ClinicService> UpdateClinicServiceAsync(ClinicService clinicService);
    public Task<bool> RemoveClinicServiceAsync(Guid id);
}
