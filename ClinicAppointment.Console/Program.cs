namespace ClinicAppointment.Console;

using System;
using ClinicAppointment.Kernel.Services.Data;

class Program
{
    static void Main(string[] args)
    {
        var dataProvider = DummyProvider.CreateProvider();
        DataSeed.SeedProvider(dataProvider);
        Console.WriteLine("Done");
    }
}
