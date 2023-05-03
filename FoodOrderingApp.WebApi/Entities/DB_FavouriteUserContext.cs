using Microsoft.EntityFrameworkCore;

namespace FoodOrderingApp.WebApi.Entities
{
    public class DB_FavouriteUserContext:DbContext
    {
        public DB_FavouriteUserContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EITNL6U\\SQLEXPRESS;Initial Catalog=FoodAppDb;Integrated Security=True");
        }
    }
}
