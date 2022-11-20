using System.ComponentModel.DataAnnotations;

namespace BizLand.Models
{
    public class Services
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
