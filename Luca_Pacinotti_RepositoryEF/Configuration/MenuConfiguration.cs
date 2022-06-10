using Microsoft.EntityFrameworkCore;
using Luca_Pacinotti_Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Luca_Pacinotti_RepositoryEF.Configuration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.HasKey(m => m.IdMenu);
            builder.Property(m => m.Nome).IsRequired();

            builder.HasMany(m => m.Piatto).WithOne(m => m.Menu).HasForeignKey(m => m.IdMenuFK);

        }
    }
}
