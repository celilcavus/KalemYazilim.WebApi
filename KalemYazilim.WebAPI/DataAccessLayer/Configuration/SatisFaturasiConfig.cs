using KalemYazilim.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalemYazilim.WebAPI.DataAccessLayer.Configuration
{
    public class SatisFaturasiConfig : IEntityTypeConfiguration<SatisFaturasi>
    {
        public void Configure(EntityTypeBuilder<SatisFaturasi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


   
            // 
            /*
             * Bazı Belge numaraları 4 bazıları 10 haneli olabiliyor
             * Bazıları belgen numaraları belgenin uzunluguna göre değişebilir
             * Sabit bir şey girmek istemedim garanti olsun istedim
             */


            builder.Property(x => x.BelgeNo)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(x => x.Musteri).WithMany(x => x.SatisFaturaSatiri);
        }
    }
}
