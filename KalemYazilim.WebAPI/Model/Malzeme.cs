namespace KalemYazilim.WebAPI.Model
{
    public class Malzeme
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; } = string.Empty;
        public string UrunMarkasi { get; set; } = string.Empty;
        public DateTime SonKullanmaTarihi { get; set; }
        public bool Aktif { get; set; }

        public Malzeme()
        {
            SonKullanmaTarihi = DateTime.Now;
        }
    }
}
