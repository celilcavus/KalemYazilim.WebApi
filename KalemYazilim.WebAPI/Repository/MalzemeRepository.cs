using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Repository
{
    public class MalzemeRepository : BaseRepository<Malzeme>
    {
        public MalzemeRepository(KalemDb kalemdb) : base(kalemdb)
        {
        }
    }
}
