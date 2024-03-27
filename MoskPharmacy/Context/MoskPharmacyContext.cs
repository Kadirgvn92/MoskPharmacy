using Microsoft.EntityFrameworkCore;
using MoskPharmacy.Models;

namespace MoskPharmacy.Context;

public class MoskPharmacyContext : DbContext
{
    public MoskPharmacyContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Drawing> Drawings { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Pharmacy> Pharmacies { get; set; }

}
