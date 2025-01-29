using AccountingService.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController :ControllerBase

    {
        public readonly IUserService _userService;

        public UserController(IUserService userService) { 
         _userService = userService;
        }

        [HttpGet("greet/{name}")]
        public string GetGreet(string name)
        {
            return _userService.GetGreeting(name);
        }

        [HttpGet("sum/{a}/{b}")]
        public int GetSum(int a, int b)
        {
            return _userService.CalculateSum(a, b);
        }

        [HttpGet("username/{userId}")]
       
        public string GetUserName(int userId)
        {
            return _userService.GetUserName(userId);
        }

    }
}
