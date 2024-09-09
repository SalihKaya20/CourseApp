using System.ComponentModel.DataAnnotations;


namespace efcoreApp.Data
{       
    public class Ogrenci
    {
        
        [Key]   // primary key
        public int OgrenciId { get; set; }  
        public string? OgreciAd { get; set; }
        public string? OgreciSoyad { get; set; }

        public string AdSoyad { 
        get 
        {
            return this.OgreciAd + " " + this.OgreciSoyad ; 
        }
        }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

        public ICollection<KursKayit> KursKayitlari {get; set ;} = new List<KursKayit>() ;


    }
}