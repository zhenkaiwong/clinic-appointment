using ClinicAppointment.Kernel.Exceptions;
using ClinicAppointment.Kernel.Models;
using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Services.Data;

public class DummyProvider : IDataProviderSync
{
    private List<Appointment> _appointments = new();
    private List<Bill> _bills = new();
    private List<ClinicService> _services = new();
    private List<Patient> _patients = new();
    private List<Doctor> _doctors = new();
    private static DummyProvider? _provider;

    private DummyProvider() { }

    public static DummyProvider CreateProvider()
    {
        if (_provider is null)
        {
            _provider = new DummyProvider();
        }

        return _provider;
    }

    public List<Appointment> GetAllAppointments()
    {
        return _appointments;
    }

    public List<Bill> GetAllBills()
    {
        return _bills;
    }

    public List<ClinicService> GetAllClinicServices()
    {
        return _services;
    }

    public List<Doctor> GetAllDoctors()
    {
        return _doctors;
    }

    public List<Patient> GetAllPatients()
    {
        return _patients;
    }

    public Appointment GetAppointment(Guid id)
    {
        try
        {
            return _appointments.Single(appointment => appointment.Id.Equals(id));
        }
        catch
        {
            throw new NotFoundException($"Cannot find appointment with id {id}");
        }
    }

    public Bill GetBill(Guid id)
    {
        try
        {
            return _bills.Single(bill => bill.Id.Equals(id));
        }
        catch
        {
            throw new NotFoundException($"Cannot find bill with id {id}");
        }
    }

    public ClinicService GetClinicService(Guid id)
    {
        try
        {
            return _services.Single(service => service.Id.Equals(id));
        }
        catch
        {
            throw new NotFoundException($"Cannot find clinic service with id {id}");
        }
    }

    public Doctor GetDoctor(Guid id)
    {
        try
        {
            return _doctors.Single(doctor => doctor.Id.Equals(id));
        }
        catch
        {
            throw new NotFoundException($"Cannot find doctor with id {id}");
        }
    }

    public Patient GetPatient(Guid id)
    {
        try
        {
            return _patients.Single(patient => patient.Id.Equals(id));
        }
        catch
        {
            throw new NotFoundException($"Cannot find patient with id {id}");
        }
    }

    public Appointment InsertAppointment(Appointment appointment)
    {
        var now = DateTime.UtcNow;
        appointment.Created = now;
        appointment.LastUpdated = now;
        _appointments.Add(appointment);
        return appointment;
    }

    public Bill InsertBill(Bill bill)
    {
        var now = DateTime.UtcNow;
        bill.Created = now;
        bill.LastUpdated = now;
        _bills.Add(bill);
        return bill;
    }

    public ClinicService InsertClinicService(ClinicService clinicService)
    {
        var now = DateTime.UtcNow;
        clinicService.Created = now;
        clinicService.LastUpdated = now;
        _services.Add(clinicService);
        return clinicService;
    }

    public Doctor InsertDoctor(Doctor doctor)
    {
        var now = DateTime.UtcNow;
        doctor.Created = now;
        doctor.LastUpdated = now;
        _doctors.Add(doctor);
        return doctor;
    }

    public Patient InsertPatient(Patient patient)
    {
        var now = DateTime.UtcNow;
        patient.Created = now;
        patient.LastUpdated = now;
        _patients.Add(patient);
        return patient;
    }

    public bool RemoveAppointment(Guid id)
    {
        try
        {
            var appointment = GetAppointment(id);
            return _appointments.Remove(appointment);
        }
        catch
        {
            return false;
        }
    }

    public bool RemoveBill(Guid id)
    {
        try
        {
            var bill = GetBill(id);
            return _bills.Remove(bill);
        }
        catch
        {
            return false;
        }
    }

    public bool RemoveClinicService(Guid id)
    {
        try
        {
            var service = GetClinicService(id);
            return _services.Remove(service);
        }
        catch
        {
            return false;
        }
    }

    public bool RemoveDoctor(Guid id)
    {
        try
        {
            var doctor = GetDoctor(id);
            return _doctors.Remove(doctor);
        }
        catch
        {
            return false;
        }
    }

    public bool RemovePatient(Guid id)
    {
        try
        {
            var patient = GetPatient(id);
            return _patients.Remove(patient);
        }
        catch
        {
            return false;
        }
    }

    public Doctor UpdateDoctor(Doctor doctor)
    {
        try
        {
            int index = _doctors.FindIndex(sourceDoctor => sourceDoctor.Id.Equals(doctor));
            if (index == -1) throw new NotFoundException($"Unable to find doctor with id {doctor.Id}");
            doctor.LastUpdated = DateTime.UtcNow;
            _doctors[index] = doctor;

            return doctor;
        }
        catch
        {
            throw new UpdateEntityFailException($"Failed to update doctor with id {doctor.Id}");
        }
    }

    public Patient UpdatePatient(Patient patient)
    {
        try
        {
            int index = _patients.FindIndex(sourcePatient => sourcePatient.Id.Equals(patient));
            if (index == -1) throw new NotFoundException($"Unable to find patient with id {patient.Id}");
            patient.LastUpdated = DateTime.UtcNow;
            _patients[index] = patient;

            return patient;
        }
        catch
        {
            throw new UpdateEntityFailException($"Failed to update patient with id {patient.Id}");
        }
    }

    public Appointment UpdateAppointment(Appointment appointment)
    {
        try
        {
            int index = _appointments.FindIndex(sourceAppointment => sourceAppointment.Id.Equals(appointment));
            if (index == -1) throw new NotFoundException($"Unable to find appointment with id {appointment.Id}");
            appointment.LastUpdated = DateTime.UtcNow;
            _appointments[index] = appointment;

            return appointment;
        }
        catch
        {
            throw new UpdateEntityFailException($"Failed to update appointment with id {appointment.Id}");
        }
    }

    public Bill UpdateBill(Bill bill)
    {
        try
        {
            int index = _bills.FindIndex(sourceBill => sourceBill.Id.Equals(bill));
            if (index == -1) throw new NotFoundException($"Unable to find bill with id {bill.Id}");
            bill.LastUpdated = DateTime.UtcNow;
            _bills[index] = bill;

            return bill;
        }
        catch
        {
            throw new UpdateEntityFailException($"Failed to update bill with id {bill.Id}");
        }
    }

    public ClinicService UpdateClinicService(ClinicService clinicService)
    {
        try
        {
            int index = _services.FindIndex(sourceService => sourceService.Id.Equals(clinicService));
            if (index == -1) throw new NotFoundException($"Unable to find clinic service with id {clinicService.Id}");
            clinicService.LastUpdated = DateTime.UtcNow;
            _services[index] = clinicService;

            return clinicService;
        }
        catch
        {
            throw new UpdateEntityFailException($"Failed to update clinic service with id {clinicService.Id}");
        }
    }
}
