using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Housing_Reservation_System.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order mustr be between 1 and 100!!!")]

        public int DisplayOrder { get; set; }

        public DateTime  CreatedDateTime{ get; set; } = DateTime.Now;
    }
}
