using Microsoft.EntityFrameworkCore;
using ClinicAppointmentPortal.Models;

namespace ClinicAppointmentPortal.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Appointment> Appointments => Set<Appointment>();
}
