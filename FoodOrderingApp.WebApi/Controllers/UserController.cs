using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodOrderingApp.WebApi.Entities;
using FoodOrderingApp.WebApi.Repository;

namespace FoodOrderingApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        //to add in the db
        [HttpPost, Route("Register")]
        public IActionResult Registration(User user)
        {
            try
            {
                userRepository.AddUser(user);
                return StatusCode(200, user);
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }

        //to fetch from db
        [HttpGet, Route("Get/{userId}")]
        public IActionResult GetUser(int userId)
        {
            try
            {
                User user = userRepository.GetUserDetails(userId);
                if (user != null)
                    return StatusCode(200, user);
                else
                    return StatusCode(404, "not found");
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }

        //to get all available Users
        [HttpGet, Route("Users")]
        public IActionResult Get()
        {
            List<User> users = userRepository.GetUsers();
            if (users != null)
            {
                return StatusCode(200, users);
            }
            else
            {
                return StatusCode(400, "Not Found");
            }
        }
        //to update in the db
        [HttpPut, Route("Update")]
        public IActionResult EditUser(User user)
        {
            try
            {
                userRepository.UpdateUser(user);
                return StatusCode(200, user);
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }

        //to delete existing resourse
        [HttpDelete, Route("Delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                userRepository.DeleteUser(id);
                return StatusCode(200, "successfull");
            }
            catch (Exception)
            {

                return StatusCode(200, "error occured");
            }
        }
    }
}
