using ClinicAppointment.Kernel.Models;
using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Services.Data;

public class DataSeed
{
    public static void SeedProvider(IDataProviderSync _provider)
    {
        for (int i = 1; i <= 10; i++)
        {
            var patient = new Patient($"Patient {i}");
            var doctor = new Doctor($"Doctor {i}");
            var service = new ClinicService($"Service {i}", doctor);

            _provider.InsertPatient(patient);
            _provider.InsertDoctor(doctor);
            _provider.InsertClinicService(service);
        }
    }

    public static void SeedAsyncProvider(IDataProviderAsync _provider)
    {

    }
}
