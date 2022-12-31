using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations;

public class UrlModelConfiguration : IEntityTypeConfiguration<UrlModel>
{
    public void Configure(EntityTypeBuilder<UrlModel> builder)
    {
        builder
            .HasOne(su => su.CreatedBy)
            .WithMany(u => u.OwnedUrls)
            .HasForeignKey(su => su.CreatedById);

        builder
            .HasIndex(su => su.URL)
            .IsUnique();
        
    }
}