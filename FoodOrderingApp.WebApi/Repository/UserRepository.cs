using FoodOrderingApp.WebApi.Contracts;
using FoodOrderingApp.WebApi.Entities;

namespace FoodOrderingApp.WebApi.Repository
{
    public class UserRepository : UserContracts
    {
        private readonly DB_FavouriteUserContext favouriteUserContext;

        public UserRepository()
        {
            favouriteUserContext = new DB_FavouriteUserContext();
        }

        public void AddUser(User user)
        {
            try
            {
                favouriteUserContext.Users.Add(user);
                favouriteUserContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                var user = favouriteUserContext.Users.Find(userId);
                favouriteUserContext.Users.Remove(user);
                favouriteUserContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUserDetails(int userId)
        {
            try
            {
                //singleordefault returns null so we have to manage that
                User user = favouriteUserContext.Users.SingleOrDefault(u => u.UserId == userId);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                favouriteUserContext.Users.Update(user);
                favouriteUserContext.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
