using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientMap : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Cpf)
            .IsRequired()
            .HasMaxLength(11);

        // CPF = chave de negócio
        builder.HasIndex(c => c.Cpf)
            .IsUnique();

        // FK
        builder.HasMany(c => c.Certificates)
            .WithOne(c => c.Client)
            .HasForeignKey(c => c.ClientId);

        builder.HasMany(c => c.Companies)
            .WithOne(c => c.Client)
            .HasForeignKey(c => c.ClientId);
    }
}
