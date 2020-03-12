using System.ComponentModel.DataAnnotations.Schema;

namespace MicroService.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
