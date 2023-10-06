using KalemYazilim.WebAPI.Interfaces;
using KalemYazilim.WebAPI.Model;
using KalemYazilim.WebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KalemYazilim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatisFaturasiSatiriController : ControllerBase
    {
        private readonly SatisFaturasiSatirlariRepository _sut;
        private readonly MalzemeRepository _malzeme;

        public SatisFaturasiSatiriController(SatisFaturasiSatirlariRepository sut, MalzemeRepository malzeme)
        {
            _sut = sut;
            _malzeme = malzeme;
        }

        [HttpGet("{belgeNo}")]
        public IEnumerable<SatisFaturaSatiri> Get(int belgeNo)
        {
            var values = _sut.GetAll().Where(x=>x.SatirNo == belgeNo);
            if (values is null)
            {
                return Enumerable.Empty<SatisFaturaSatiri>();
            }
            return values.ToList();
        }

        [HttpPost]
        public IActionResult Post(SatisFaturaSatiri satis)
        {
            var MalzemeIsActive = _malzeme.Get(satis.MalzemeId);
            if (MalzemeIsActive.Aktif == true)
            {
                SatisFaturaSatiri satisFatura = new SatisFaturaSatiri();
                satisFatura.SatirNo = satis.SatirNo;
                satisFatura.SatisFaturasiId = satis.SatisFaturasiId;
                satisFatura.MalzemeId = satis.MalzemeId;
                satisFatura.Birim = satis.Birim;
                satisFatura.Miktar = satis.Miktar;
                satisFatura.Fiyat = (satis.Birim * satis.Miktar);
                _sut.Add(satisFatura);
                _sut.SaveChanges();
                return Ok(200);
            }
            else
                return BadRequest();
          
        }

        [HttpPut]
        public IActionResult Put(SatisFaturaSatiri satis)
        {
            var satisFatura = _sut.Get(satis.Id);
            satisFatura.SatirNo = satis.SatirNo;
            satisFatura.SatisFaturasiId = satis.SatisFaturasiId;
            satisFatura.MalzemeId = satis.MalzemeId;
            satisFatura.Birim = satis.Birim;
            satisFatura.Miktar = satis.Miktar;
            satisFatura.Fiyat = (satis.Birim * satis.Miktar);
            _sut.Update(satisFatura);
            _sut.SaveChanges();
            return Ok(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id >= 1)
            {
                var values = _sut.Get(_id.Value);
                if (values is null)
                {
                    return BadRequest();
                }
                else
                    _sut.Delete(values);
                _sut.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
