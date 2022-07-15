using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Blog_Toanhq.Models
{
    public class Blog
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "Tiêu đề")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Mô tả ngắn")]
        public string Description { get; set; }

        [Display(Name = "Chi tiết")]
        public string Detail { get; set; }

        public string Image { get; set; }

        [Display(Name = "Vị trí")]
        public string Position { get; set; }

        [Display(Name = "Public")]
        public string Public { get; set; }

        [Display(Name = "Loại")]
        public string Category { get; set; }

        [Display(Name = "Public Date")]
        [DataType(DataType.Date)]
        public DateTime PublicDate { get; set; }
    }
}
