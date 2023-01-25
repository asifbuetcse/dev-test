using dev_test.DTOs;
using dev_test.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dev_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
        [HttpPost]
        public bool Post([FromBody] User user) 
        {
            try
            {
                _userService.PostUser(user);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
