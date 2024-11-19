using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public RoleController(IOMSSevice repository) 
        {
            _repository = repository;  
        }
        [HttpGet]
        [Route("getroles")]
        public async Task<IActionResult> GetRoles()
        {
            var res = await _repository.GetRoles();
            return Ok(res);
        }

        [HttpGet]
        [Route("getrolebyid")]
        public async Task<IActionResult> GetRoleById(Guid id)
        {
            var res = await _repository.GetRoleById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addrole")]
        public async Task<IActionResult> AddRole(RoleResponse role)
        {
            var res = await _repository.AddRole(role);
            return Ok(res);
        }

        [HttpPut]
        [Route("updaterole")]
        public async Task<IActionResult> UpdateRole(Guid id, RoleResponse role)
        {
            var res = await _repository.UpdateRole(id, role);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deleterolebyid")]

        public async Task<IActionResult> DeleteRoleById(Guid id)
        {
            var res = await _repository.DeleteRoleById(id);
            return Ok(res);
        }
    }
}
