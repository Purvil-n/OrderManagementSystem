using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public UserController(IOMSSevice repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getusers")]
        public async Task<IActionResult> GetUsers()
        {
            var res = await _repository.GetUsers();
            return Ok(res);
        }

        [HttpGet]
        [Route("getuserbyid")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var res = await _repository.GetUserById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("adduser")]
        public async Task<IActionResult> AddUser(UserResponse user)
        {
            var res = await _repository.AddUser(user);
            return Ok(res);
        }

        [HttpPut]
        [Route("updateuser")]
        public async Task<IActionResult> UpdateUser(Guid id, UserResponse user)
        {
            var res = await _repository.UpdateUser(id, user);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deleteuserbyid")]

        public async Task<IActionResult> DeleteUserById(Guid id)
        {
            var res = await _repository.DeleteUserById(id);
            return Ok(res);
        }
    }
}
