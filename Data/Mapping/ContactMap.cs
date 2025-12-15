using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ContactMap : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Email1)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Email2)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Cell1)
            .HasMaxLength(20);

        builder.Property(c => c.Cell2)
            .HasMaxLength(20);

    }
}
