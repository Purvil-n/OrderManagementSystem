using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public StatusController(IOMSSevice repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("getstatus")]
        public async Task<IActionResult> GetStatus()
        {
            var res = await _repository.GetStatus();
            return Ok(res);
        }

        [HttpGet]
        [Route("getstatusbyid")]
        public async Task<IActionResult> GetStatusById(Guid id)
        {
            var res = await _repository.GetStatusById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addstatus")]
        public async Task<IActionResult> AddStatus(StatusResponse status)
        {
            var res = await _repository.AddStatus(status);
            return Ok(res);
        }

        [HttpPut]
        [Route("updatestatus")]
        public async Task<IActionResult> UpdateStatus(Guid id, StatusResponse status)
        {
            var res = await _repository.UpdateStatus(id, status);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deletestatusbyid")]

        public async Task<IActionResult> DeleteStatusById(Guid id)
        {
            var res = await _repository.DeleteStatusById(id);
            return Ok(res);
        }
    }
}
