using System.ComponentModel.DataAnnotations;

namespace CoreDepartmanPersonel.Models
{
    public class departmanlar
    {
        [Key]
        public int departid { get; set; }
        public string departmanad { get; set; }
        public IList<personel> personels { get; set; }
    }
}
