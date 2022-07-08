using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Blog_Toanhq.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        public string? Title { get; set; }
        
        [Display(Name = "Mô tả ngắn")]
        public string? Description { get; set; }
        
        [Display(Name = "Chi tiết")]
        public string? Detail { get; set; }
        
        [Display(Name = "Vị trí")]
        public string? Position { get; set; }

        [Display(Name = "Public")]
        public Boolean IsPublic { get; set; }

        [Display(Name = "Loại")]
        public string? Category { get; set; }

        [Display(Name = "Public Date")]
        [DataType(DataType.Date)]
        public DateTime PublicDate { get; set; }
    }
}
