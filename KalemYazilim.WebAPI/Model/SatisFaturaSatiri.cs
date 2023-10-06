namespace KalemYazilim.WebAPI.Model
{
    public class SatisFaturaSatiri
    {
        public int Id { get; set; }
        public int SatirNo { get; set; }

        public int SatisFaturasiId { get; set; }
        public SatisFaturasi? SatisFaturasi { get; set; }
        public int MalzemeId { get; set; }
        public Int32 Birim { get; set; }
        public Int32 Miktar { get; set; }
        public decimal Fiyat { get; set; }

        public SatisFaturaSatiri()
        {
            Fiyat = (Miktar * Birim);
        }


        //{
        //   "SatirNo":1234,
        //   "SatisFaturasiId":1,
        //   "MalzemeId":1,
        //   "Birim":30,
        //   "Miktar":1,
        //   "Fiyat":30

        //}
    }
}
