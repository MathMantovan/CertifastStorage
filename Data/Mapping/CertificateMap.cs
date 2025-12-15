using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CertificateMap : IEntityTypeConfiguration<Certificate>
{
    public void Configure(EntityTypeBuilder<Certificate> builder)
    {
        builder.ToTable("Certificates");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .IsRequired();

        builder.Property(c => c.ExpiringDate)
            .IsRequired();

        builder.HasIndex(c => c.ExpiringDate);

        // pedido
        builder.HasIndex(c => c.OrderId)
            .IsUnique();

        // FKs (índices MUITO importantes)
        builder.HasIndex(c => c.ClientId);
        builder.HasIndex(c => c.CompanyId);
        builder.HasIndex(c => c.CertificateTypeId);
        builder.HasIndex(c => c.AgentResponsableId);

        builder.HasOne(c => c.Client)
            .WithMany(c => c.Certificates)
            .HasForeignKey(c => c.ClientId);

        builder.HasOne(c => c.Company)
            .WithMany(c => c.Certificates)
            .HasForeignKey(c => c.CompanyId)
            .IsRequired(false);

        builder.HasOne(c => c.CertificateType)
            .WithMany()
            .HasForeignKey(c => c.CertificateTypeId);

        builder.HasOne(c => c.AgentResponsable)
            .WithMany(a => a.Certificates)
            .HasForeignKey(c => c.AgentResponsableId);
    }
}

