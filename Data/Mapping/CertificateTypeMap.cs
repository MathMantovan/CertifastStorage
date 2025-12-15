using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CertificateTypeMap : IEntityTypeConfiguration<CertificateType>
{
    public void Configure(EntityTypeBuilder<CertificateType> builder)
    {
        builder.ToTable("CertificateTypes");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.ProductType).IsRequired();
        builder.Property(c => c.Level).IsRequired();
        builder.Property(c => c.StorageType).IsRequired();
        builder.Property(c => c.ValidityInMonths).IsRequired();
        builder.Property(c => c.Authority).IsRequired();

        // evita duplicar produto
        builder.HasIndex(c => new
        {
            c.ProductType,
            c.Level,
            c.StorageType,
            c.ValidityInMonths,
            c.Authority
        })
        .IsUnique();
    }
}
