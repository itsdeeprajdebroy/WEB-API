using FoodOrderingApp.WebApi.Entities;

namespace FoodOrderingApp.WebApi.Contracts
{
    public interface IFoodContracts
    {
        public List<Food> GetFoods();
        public Food GetFoodByName(string foodName);
        public Food GetFoodById(int foodId);
    }
}
