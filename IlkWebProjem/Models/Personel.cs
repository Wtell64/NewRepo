using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IlkWebProjem.Models
{


    public class Personel
    {
        [Display(Name ="Personel Adi")]
        [StringLength(50, ErrorMessage ="Bu alana en fazla 50 karakter yazilabilir")] //annotation
        public string Ad { get; set; }

        [DisplayName("Personel Soyadi")]
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public bool Aktif { get; set; }
    }
}
