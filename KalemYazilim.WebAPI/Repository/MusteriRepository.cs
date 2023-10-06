using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Repository
{
    public class MusteriRepository : BaseRepository<Musteri>
    {
        public MusteriRepository(KalemDb kalemdb) : base(kalemdb)
        {
        }
    }
}
