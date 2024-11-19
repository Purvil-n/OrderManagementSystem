using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public ItemController(IOMSSevice repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("getitems")]
        public async Task<IActionResult> GetItems()
        {
            var res = await _repository.GetItems();
            return Ok(res);
        }

        [HttpGet]
        [Route("getitembyid")]
        public async Task<IActionResult> GetItemById(Guid id)
        {
            var res = await _repository.GetItemById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("additem")]
        public async Task<IActionResult> AddItem(ItemResponse item)
        {
            var res = await _repository.AddItem(item);
            return Ok(res);
        }

        [HttpPut]
        [Route("updateitem")]
        public async Task<IActionResult> UpdateItem(Guid id, ItemResponse item)
        {
            var res = await _repository.UpdateItem(id, item);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deleteitembyid")]

        public async Task<IActionResult> DeleteItemById(Guid id)
        {
            var res = await _repository.DeleteItemById(id);
            return Ok(res);
        }

        [HttpGet]
        [Route("getdetailsbyid")]
        public async Task<IActionResult> GetDetailsById(Guid id)
        {
            var res = await _repository.GetDetailsById(id);
            return Ok(res);
        }
    }
}
