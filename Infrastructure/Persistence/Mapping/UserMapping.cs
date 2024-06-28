using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Mapping;

public class UserMapping : EntityTypeConfiguration<User>
{

    /// <summary>
    /// Configures the entity
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity</param>
    /// <param name="entity"></param>
    public override void Configure(EntityTypeBuilder<User> entity)
    {
        #region Configures
        entity.ToTable(nameof(User), "public");

        entity.HasKey(u => u.Id);

        entity.HasIndex(u => u.Name).IsUnique();

        entity.HasIndex(u => u.Email).IsUnique();

        entity.Property(u => u.IsAdmin).IsRequired().HasDefaultValue(false);
        
        entity.Property(_ => _.IsDeleted).IsRequired().HasDefaultValue(false);
        entity.Property(_ => _.CreatedById).IsRequired();
        entity.Property(_ => _.CreatedByName).IsRequired().HasMaxLength(256);
        entity.Property(_ => _.CreatedDateTime).IsRequired();
        entity.Property(_ => _.UpdateById).IsRequired(false);
        entity.Property(_ => _.UpdatedByName).IsRequired(false).HasMaxLength(256);
        entity.Property(_ => _.UpdatedTime).IsRequired(false);
        
        #endregion
        
        #region Seeding data
        #endregion

        base.Configure(entity);
    }
}