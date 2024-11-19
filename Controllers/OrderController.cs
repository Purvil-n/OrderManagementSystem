using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public OrderController(IOMSSevice repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("getorders")]
        public async Task<IActionResult> GetOrders()
        {
            var res = await _repository.GetOrders();
            return Ok(res);
        }

        [HttpGet]
        [Route("getorderbyid")]
        public async Task<IActionResult> GetOrderById(Guid id)
        {
            var res = await _repository.GetOrderById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addorder")]
        public async Task<IActionResult> AddOrder(OrderResponse order)
        {
            var res = await _repository.AddOrder(order);
            return Ok(res);
        }

        [HttpPut]
        [Route("updateorder")]
        public async Task<IActionResult> UpdateOrder(Guid id, OrderResponse order)
        {
            var res = await _repository.UpdateOrder(id, order);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deleteorderbyid")]

        public async Task<IActionResult> DeleteOrderById(Guid id)
        {
            var res = await _repository.DeleteOrderById(id);
            return Ok(res);
        }
    }
}
