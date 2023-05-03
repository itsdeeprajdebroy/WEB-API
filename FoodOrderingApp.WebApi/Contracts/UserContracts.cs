using FoodOrderingApp.WebApi.Entities;

namespace FoodOrderingApp.WebApi.Contracts
{
    public interface UserContracts
    {
        public void AddUser(User user);
        public void UpdateUser(User user);
        public User GetUserDetails(int userId);
        public void DeleteUser(int userId);
    }
}
