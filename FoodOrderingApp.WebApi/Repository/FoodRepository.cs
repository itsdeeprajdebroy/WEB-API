using FoodOrderingApp.WebApi.Contracts;
using FoodOrderingApp.WebApi.Entities;

namespace FoodOrderingApp.WebApi.Repository
{
    public class FoodRepository : IFoodContracts
    {
        private DB_FavouriteUserContext _userContext;

        public FoodRepository()
        {
            _userContext= new DB_FavouriteUserContext();
        }
        public Food GetFoodById(int foodId)
        {
            try
            {
                Food food = _userContext.Foods.Find(foodId);
                return food;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Food GetFoodByName(string foodName)
        {
            Food food = _userContext.Foods.SingleOrDefault(f => f.FoodName == foodName);
            return food;
        }

        public List<Food> GetFoods()
        {
            try
            {
                List<Food> foods = _userContext.Foods.ToList();
                return foods;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
