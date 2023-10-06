
using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Interfaces;
using KalemYazilim.WebAPI.Model;
using KalemYazilim.WebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KalemYazilim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {

        private readonly MusteriRepository musteriRepository;
        public MusteriController(MusteriRepository musteriRepository)
        {
            this.musteriRepository = musteriRepository;
        }


        public IEnumerable<Musteri> Get()
        {
            var values = musteriRepository.GetAll(true);
            if (values is null)
            {
                return Enumerable.Empty<Musteri>();
            }
            return values.ToList();
        }
        [HttpGet("{id}")]
        public Musteri Get(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id >= 1)
            {
                var values = musteriRepository.Get(_id.Value);
                if (values is null)
                {
                    return Enumerable.Empty<Musteri>().Single();
                }
                return values;
            }
            return Enumerable.Empty<Musteri>().Single();

        }

        [HttpPost]
        public IActionResult Post(Musteri musteri)
        {
            musteriRepository.Add(musteri);
            musteriRepository.SaveChanges();
            return Ok(200);
        }

        [HttpPut]
        public IActionResult Put(Musteri musteri)
        {
            musteriRepository.Update(musteri);
            musteriRepository.SaveChanges();
            return Ok(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id >= 1)
            {
                var values = musteriRepository.Get(_id.Value);
                if (values is null)
                {
                    return BadRequest();
                }
                else
                    musteriRepository.Delete(values);
                musteriRepository.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
