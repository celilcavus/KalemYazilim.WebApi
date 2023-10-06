using KalemYazilim.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalemYazilim.WebAPI.DataAccessLayer.Configuration
{
    public class SatisFaturasiSatiriConfig : IEntityTypeConfiguration<SatisFaturaSatiri>
    {
        public void Configure(EntityTypeBuilder<SatisFaturaSatiri> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Birim).IsRequired();

            builder.Property(x => x.MalzemeId).IsRequired();
        }
    }
}
