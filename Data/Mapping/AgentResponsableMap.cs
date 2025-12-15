using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AgentResponsableMap : IEntityTypeConfiguration<AgentResponsable>
{
    public void Configure(EntityTypeBuilder<AgentResponsable> builder)
    {
        builder.ToTable("AgentResponsibles");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.AgentPoint)
            .IsRequired()
            .HasMaxLength(200);

        // busca frequente
        builder.HasIndex(a => a.AgentPoint);

        builder.HasMany(a => a.Certificates)
            .WithOne(c => c.AgentResponsable)
            .HasForeignKey(c => c.AgentResponsableId);
    }
}
