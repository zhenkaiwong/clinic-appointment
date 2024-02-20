using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointment.Kernel.Exceptions;

public class UpdateEntityFailException : Exception
{
    public UpdateEntityFailException(string message) : base(message)
    {

    }
}
