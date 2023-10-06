namespace KalemYazilim.WebAPI.Model
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; } = String.Empty;
        public string Soyad { get; set; } = String.Empty;
        public string VKN { get; set; } = String.Empty;
        public string TCKN { get; set; } = String.Empty;
        public bool Aktif { get; set; }

        public ICollection<SatisFaturasi>? SatisFaturaSatiri { get; set; }

    }
}
