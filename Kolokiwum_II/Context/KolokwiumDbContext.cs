using Kolokiwum_II.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kolokiwum_II.Context;

public sealed class KolokwiumDbContext : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    
    public DbSet<Patient> Patients { get; set; }
    
    public DbSet<Visit> Visites { get; set; }
    
    public KolokwiumDbContext(DbContextOptions<KolokwiumDbContext> options) : base(options)
    {
    }
}