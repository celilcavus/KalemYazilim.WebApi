using KalemYazilim.WebAPI.Interfaces;
using KalemYazilim.WebAPI.Model;
using KalemYazilim.WebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KalemYazilim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatisFaturasiController : ControllerBase
    {
        private readonly SatisFaturasiRepository _satisfaturasi;
        private readonly SatisFaturasiSatirlariRepository _satisfaturasisatiri;
        private readonly MusteriRepository _musteri;

        public SatisFaturasiController(SatisFaturasiRepository satisfaturasi, SatisFaturasiSatirlariRepository satisfaturasisatiri, MusteriRepository musteri)
        {
            _satisfaturasi = satisfaturasi;
            _satisfaturasisatiri = satisfaturasisatiri;
            _musteri = musteri;
        }
        [HttpGet("{karar}")]
        public IEnumerable<SatisFaturasi> Get(int karar)
        {

            if (karar == 1)
            {

                var values = _satisfaturasi.GetAll();
                if (values is null)
                {
                    return Enumerable.Empty<SatisFaturasi>();
                }
                return values.ToList();
            }
            else if (karar == 0)
            {
                var values = _satisfaturasi.GetAll();
                if (values is null)
                {
                    return Enumerable.Empty<SatisFaturasi>();
                }
                return values.ToList();
            }
            return default;
        }

        [HttpPost]
        public IActionResult Post(SatisFaturasi satis)
        {
            var MusteriIsActive = _musteri.Get(satis.MusteriId);
            if (MusteriIsActive.Aktif == true)
            {
                _satisfaturasi.Add(satis);
                _satisfaturasi.SaveChanges();
                return Ok(201);
            }
            return BadRequest();


        }
        [HttpPut]
        public IActionResult Put(SatisFaturasi satis)
        {
            _satisfaturasi.Update(satis);
            _satisfaturasi.SaveChanges();
            return Ok(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id >= 1)
            {
                var values = _satisfaturasi.Get(_id.Value);
                if (values is null)
                {
                    return BadRequest();
                }
                else
                    _satisfaturasi.Delete(values);
                _satisfaturasi.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
