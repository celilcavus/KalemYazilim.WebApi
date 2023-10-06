namespace KalemYazilim.WebAPI.Model
{
    public class SatisFaturasi
    {
        public int Id { get; set; }
        public int BelgeNo { get; set; }
        public DateTime BelgeTarihi { get; set; }
        //Müşteri classi ile burası referans verilicek..
        public int MusteriId { get; set; }  
        public Musteri? Musteri { get; set; }
        public ICollection<SatisFaturaSatiri>? SatisFaturaSatiri { get; set; }
        public SatisFaturasi()
        {
            BelgeTarihi = DateTime.Now;
        }
    }
}
