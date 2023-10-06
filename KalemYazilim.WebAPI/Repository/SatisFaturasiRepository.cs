using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Repository
{
    public class SatisFaturasiRepository : BaseRepository<SatisFaturasi>
    {
        public SatisFaturasiRepository(KalemDb kalemdb) : base(kalemdb)
        {
        }
    }
}
