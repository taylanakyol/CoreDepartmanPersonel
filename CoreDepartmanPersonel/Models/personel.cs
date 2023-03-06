using System.ComponentModel.DataAnnotations;

namespace CoreDepartmanPersonel.Models
{
    public class personel
    {
        [Key]
        public int perid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }

        public departmanlar depart { get; set; }
    }
}
