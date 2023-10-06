using KalemYazilim.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalemYazilim.WebAPI.DataAccessLayer.Configuration
{
    public class MusteriConfig : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Ad)
                .HasMaxLength(25);

            builder.Property(x => x.Soyad)
                .HasMaxLength(25);

            builder.Property(x => x.Soyad)
               .HasMaxLength(25);

            builder.Property(x => x.VKN)
               .HasMaxLength(11);

            builder.Property(x => x.TCKN)
              .HasMaxLength(11);

            
        }
    }
}
