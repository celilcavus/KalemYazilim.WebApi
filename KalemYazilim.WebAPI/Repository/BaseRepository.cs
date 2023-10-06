using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Interfaces;
using KalemYazilim.WebAPI.Migrations;
using Microsoft.EntityFrameworkCore;

namespace KalemYazilim.WebAPI.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly KalemDb _kalemdb;

        public BaseRepository(KalemDb kalemdb)
        {
            _kalemdb = kalemdb;
        }

        public void Add(T entity)
        {
            _kalemdb.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _kalemdb.Set<T>().Remove(entity);
        }

        public T Get(int id)
        {
            return _kalemdb.Set<T>().Find(id)!;
        }

        public IEnumerable<T> GetAll(bool Track = true)
        {

            if (Track == true)
            {
                return _kalemdb.Set<T>().AsNoTracking().ToList();
            }
            else
                return _kalemdb.Set<T>().ToList();

        }

        public int SaveChanges()
        {
            return _kalemdb.SaveChanges();
        }

        public void Update(T entity)
        {
            _kalemdb.Update(entity);
        }
    }
}
