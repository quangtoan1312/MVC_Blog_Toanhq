using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Blog_Toanhq.Models
{
    public class BlogDto
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [DisplayName("Tiêu đề")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Mô tả ngắn không được để trống")]
        [DisplayName("Mô tả ngắn")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Chi tiết không được để trống")]
        [DisplayName("Chi tiết")]
        public string Detail { get; set; }

        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [DisplayName("Vị trí")]
        public string Position { get; set; }

        public bool Public { get; set; }

        [DisplayName("Loại")]
        public string Category { get; set; }

        [DisplayName("Public Date")]
        [DataType(DataType.Date)]
        public DateTime PublicDate { get; set; }

        public List<SelectListItem> PositionList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem {Value="Việt Nam", Text="Việt Nam"},
            new SelectListItem {Value = "Châu Á", Text="Châu Á"},
            new SelectListItem {Value = "Châu Âu", Text="Châu Âu"},
            new SelectListItem {Value = "Châu Mỹ", Text="Châu Mỹ"}
        };

        public List<SelectListItem> CategoryList { get; set; } = new List<SelectListItem>
        {
             new SelectListItem {Value="Pháp Luật", Text="Pháp Luật"},
             new SelectListItem {Value="Chính Trị", Text="Chính Trị"},
             new SelectListItem {Value="Quân Sự", Text="Quân Sự"},
             new SelectListItem {Value="Giải trí", Text="Giải trí"}
        };
    }
}
