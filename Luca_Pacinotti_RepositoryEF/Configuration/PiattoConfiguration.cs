using Luca_Pacinotti_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Luca_Pacinotti_RepositoryEF.Configuration
{
    internal class PiattoConfiguration : IEntityTypeConfiguration<Piatto>
    {
        public void Configure(EntityTypeBuilder<Piatto> builder)
        {
            builder.ToTable("Piatto");
            builder.HasKey(p => p.IdPiatto);


            builder.HasOne(p => p.Menu).WithMany(m => m.Piatto).HasForeignKey(p => p.IdMenuFK);
        }
    }
}
