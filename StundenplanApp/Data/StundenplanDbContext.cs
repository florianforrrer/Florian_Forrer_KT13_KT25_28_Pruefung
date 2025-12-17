using Microsoft.EntityFrameworkCore;

namespace StundenplanApp.Data;

public partial class StundenplanDbContext : DbContext
{
    public StundenplanDbContext(DbContextOptions<StundenplanDbContext> options)
        : base(options)
    {
    }

    public DbSet<Stundenplan> Stundenplans => Set<Stundenplan>();
    public DbSet<Klassen> Klassens => Set<Klassen>();
    public DbSet<Lehrer> Lehrers => Set<Lehrer>();
    public DbSet<Schulzimmer> Schulzimmers => Set<Schulzimmer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Tabellen-Namen (so wie sie in SQL heissen – passt bei dir sehr wahrscheinlich)
        modelBuilder.Entity<Stundenplan>().ToTable("Stundenplan");
        modelBuilder.Entity<Klassen>().ToTable("Klassen");
        modelBuilder.Entity<Lehrer>().ToTable("Lehrer");
        modelBuilder.Entity<Schulzimmer>().ToTable("Schulzimmer");
    }
}
