using FoodOrderingApp.WebApi.Entities;
using System.Collections.Generic;

namespace FoodOrderingApp.WebApi.Contracts
{
    public interface UserContracts
    {
        public void AddUser(User user);
        public void UpdateUser(User user);
        public User GetUserDetails(int userId);
        public List<User> GetUsers();
        public void DeleteUser(int userId);
    }
}
