using Bigon2.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bigon2.Models.Persistences.Configurations
{
    public static class ConfigurationHelper
    {
        public static EntityTypeBuilder<T> ConfigureAsAuditable<T>(this EntityTypeBuilder<T> builder)
            where T : AuditableEntity
        {
            builder.Property(m => m.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();


            builder.Property(m => m.ModifiedBy).HasColumnType("int");
            builder.Property(m => m.ModifiedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("datetime");
            builder.Property(m => m.DeletedAt).HasColumnType("datetime");


            return builder;
        }
    }
}
