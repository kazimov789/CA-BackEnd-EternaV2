using System.ComponentModel.DataAnnotations;

namespace Eterna2WithDb.Models
{
    public class PortfolioImages
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
