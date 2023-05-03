using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingApp.WebApi.Entities
{
    [Table("User")]
    public class User
    {
        [Key] //primary key
        public int UserId { get; set; }

        [StringLength(30)] //user-name
        [Column(TypeName = "varchar")]
        public string? UserName { get; set; }


        [StringLength(30)] //email-id
        [Column(TypeName = "varchar")]
        public string? EmailAdd { get; set; }

        [StringLength(15)] //phone-no
        [Column(TypeName = "varchar")]
        public string? PhNo { get; set; }

        //? -> indicates nullable type
        [StringLength(15)] //password for login
        [Column(TypeName = "varchar")]
        public string? Password { get; set; }
    }
}
