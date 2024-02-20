using ClinicAppointment.Kernel.Models.Users;

namespace ClinicAppointment.Kernel.Models;

public class Bill : BaseEntity
{
    public DateTime BillDate { get; set; }
    public Appointment? Appointment { get; set; }

    public Bill(DateTime billDate, Appointment appointment)
    {
        BillDate = billDate;
        Appointment = appointment;
    }
}
