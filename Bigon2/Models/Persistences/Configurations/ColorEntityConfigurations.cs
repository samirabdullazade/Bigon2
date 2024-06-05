using Bigon2.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bigon2.Models.Persistences.Configurations
{
    public class ColorEntityConfigurations : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(m  => m.Id).HasColumnType("int").UseIdentityColumn(10,2);
            builder.Property(m => m.Name).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            builder.Property(m => m.HexCode).HasColumnType("varchar").HasMaxLength(20).IsRequired();

            builder.ConfigureAsAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Colors");

        }
    }
}
