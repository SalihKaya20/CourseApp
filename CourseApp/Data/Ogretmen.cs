using System.ComponentModel.DataAnnotations;


namespace efcoreApp.Data
{
    public class Ogretmen 
    {   
        [Key]
        public int OgretmenId { get; set; }
        public string? OgretmenAd { get; set;}
        public string? OgretmenSoyad { get; set; }
        public string OgretmenAdSoyad
        {
            get
            {
                return this.OgretmenAd + " " + OgretmenSoyad ;
            }
        }
        public string? Telefon { get; set; }
        public string? Eposta { get; set; }

        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}",ApplyFormatInEditMode = true )]
        public DateTime BaslamaTarihi { get; set; }

        public ICollection<Kurs> Kurslar {get; set ;} = new List<Kurs>() ;


    }
}