using KalemYazilim.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalemYazilim.WebAPI.DataAccessLayer.Configuration
{
    public class MalzemeConfig : IEntityTypeConfiguration<Malzeme>
    {
        public void Configure(EntityTypeBuilder<Malzeme> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x=>x.UrunAdi)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.UrunMarkasi)
                .IsRequired()
                .HasMaxLength(100);

            
        }
    }
}
