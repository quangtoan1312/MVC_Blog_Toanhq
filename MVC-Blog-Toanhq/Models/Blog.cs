using System.ComponentModel.DataAnnotations;

namespace MVC_Blog_Toanhq.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Detail { get; set; }
        public string? Position { get; set; }
        public Boolean IsPublic { get; set; }

        public string? Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublicDate { get; set; }
    }
}
