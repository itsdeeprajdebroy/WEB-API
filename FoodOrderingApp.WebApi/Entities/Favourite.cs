using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingApp.WebApi.Entities
{
    [Table("Favourite")]
    public class Favourite
    {
        [Key]
        public int FavId { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }

        [ForeignKey("Foods")]
        public int FoodId { get; set; }

        //Reference of user and food
        //Favourite has-A User and Food
        public User? Users { get; set; }
        public Food? Foods { get; set; }
    }
}
