using System.ComponentModel.DataAnnotations;

namespace Hafta3.Models
{
    public class Yazarlar
    {
        //[Key]
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
    }
}
