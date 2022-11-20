using System.ComponentModel.DataAnnotations;

namespace BizLand.Models
{
    public class Testimonials
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(30)]
        public string Fullname { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
