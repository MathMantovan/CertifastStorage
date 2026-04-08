using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;

public class CertificateDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<CertificateType> CertificateTypes { get; set; }
    public DbSet<AgentResponsable> AgentResponsable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlServer("Server=tcp:storagecertificate.database.windows.net,1433;Database=certificatedb;User Id=CloudSAc2d658cd;Password=Matheus@dani01;Encrypt=True;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CertificateDbContext).Assembly);
    }
}
 