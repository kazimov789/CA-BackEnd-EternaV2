using System.ComponentModel.DataAnnotations;

namespace Eterna2WithDb.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int PortfolioImagesId { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
        public PortfolioImages PortfolioImages { get; set; }
    }
}
