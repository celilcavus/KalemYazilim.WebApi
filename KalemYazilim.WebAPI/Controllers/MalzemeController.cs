using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Model;
using KalemYazilim.WebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KalemYazilim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MalzemeController : ControllerBase
    {
        private readonly MalzemeRepository m_repository;

        public MalzemeController(MalzemeRepository repository)
        {
            m_repository = repository;
        }

        public IEnumerable<Malzeme> Get()
        {
            var values = m_repository.GetAll();
            if (values is null)
            {
                return Enumerable.Empty<Malzeme>();
            }
            return values.ToList();
        }


        [HttpGet("{id}")]
        public Malzeme Get(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id >= 1)
            {
                var values = m_repository.Get(_id.Value);
                if (values is null)
                {
                    return Enumerable.Empty<Malzeme>().Single();
                }
                return values;
            }
            return Enumerable.Empty<Malzeme>().Single();

        }

        [HttpPost]
        public IActionResult Post(Malzeme malzeme)
        {
            m_repository.Add(malzeme);
            m_repository.SaveChanges();
            return Ok(200);
        }

        [HttpPut]
        public IActionResult Put(Malzeme malzeme)
        {
            m_repository.Update(malzeme);
            m_repository.SaveChanges();
            return Ok(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id >= 1)
            {
                var values = m_repository.Get(_id.Value);
                if (values is null)
                {
                    return BadRequest();
                }
                else
                    m_repository.Delete(values);
                    m_repository.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
