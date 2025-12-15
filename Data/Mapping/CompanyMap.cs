using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CompanyMap : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Companies");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.CompanyName)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(c => c.Cnpj)
            .IsRequired()
            .HasMaxLength(14);

        // CNPJ = chave de negócio
        builder.HasIndex(c => c.Cnpj)
            .IsUnique();

        // Consultas por cliente
        builder.HasIndex(c => c.ClientId);

        builder.HasMany(c => c.Certificates)
            .WithOne(c => c.Company)
            .HasForeignKey(c => c.CompanyId)
            .IsRequired(false);
    }
}
