using FoodOrderingApp.WebApi.Entities;
using FoodOrderingApp.WebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly FoodRepository foodRepository;

        public FoodController()
        {
            foodRepository = new FoodRepository();
        }

        [HttpGet, Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            try
            {
                List<Food> foods = foodRepository.GetFoods();
                return StatusCode(200, foods);
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }
        [HttpGet, Route("GetFood/{FoodName}")]
        public IActionResult GetByName(string foodName)
        {
            try
            {
                Food product = foodRepository.GetFoodByName(foodName);
                if (product != null)
                    return StatusCode(200, product);
                else
                    return StatusCode(404, "not found");
            }
            catch (Exception)
            {
                return StatusCode(401, "error occured");
            }
        }
        [HttpGet, Route("GetProductByProductId/{pId}")]
        public IActionResult GetProductByPid(int pId)
        {
            try
            {
                Food product = foodRepository.GetFoodById(pId);
                if (product != null)
                    return StatusCode(200, product);
                else
                    return StatusCode(404, "not found");
            }
            catch (Exception)
            {
                return StatusCode(401, "error occured");
            }
        }
    }
}
