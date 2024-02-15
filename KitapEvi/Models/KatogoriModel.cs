namespace KitapEvi.Models
{
    public class KatogoriModel
    {
        public int KatogoriId { get; set; }
        public string KatogoriAdi { get; set; }

        List<KitapModel> kitapListesi=new List<KitapModel>();
    }
}
