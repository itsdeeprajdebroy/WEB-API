using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingApp.WebApi.Entities
{
    [Table("Food")]
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [StringLength(100)]
        [Column(TypeName = "varchar")]
        public string? FoodName { get; set; }

        public double? Price { get; set; }

        [StringLength(8000)]
        [Column(TypeName = "varchar")]
        public string? DescriptionOfFood { get; set; }

        public int Quantity { get; set; }
    }
}
