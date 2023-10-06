using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Repository
{
    public class SatisFaturasiSatirlariRepository : BaseRepository<SatisFaturaSatiri>
    {
        public SatisFaturasiSatirlariRepository(KalemDb kalemdb) : base(kalemdb)
        {
        }
    }
}
