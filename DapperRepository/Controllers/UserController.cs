using DapperRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DapperRepository.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()    
        {
            var result = await _userRepository.GetAllAsync();
            return Ok(result);
        }
    }
}
