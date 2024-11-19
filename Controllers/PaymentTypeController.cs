using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public PaymentTypeController(IOMSSevice repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("getpaymenttypes")]
        public async Task<IActionResult> GetPaymentTypes()
        {
            var res = await _repository.GetPaymentTypes();
            return Ok(res);
        }

        [HttpGet]
        [Route("getpaymenttypebyid")]
        public async Task<IActionResult> GetPaymentTypeById(Guid id)
        {
            var res = await _repository.GetPaymentTypeById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addpaymenttype")]
        public async Task<IActionResult> AddPaymentType(PaymentTypeResponse paymenttype)
        {
            var res = await _repository.AddPaymentType(paymenttype);
            return Ok(res);
        }

        [HttpPut]
        [Route("updatepaymenttype")]
        public async Task<IActionResult> UpdatePaymentType(Guid id, PaymentTypeResponse paymenttype)
        {
            var res = await _repository.UpdatePaymentType(id, paymenttype);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deletepaymenttypebyid")]

        public async Task<IActionResult> DeletePaymentTypeById(Guid id)
        {
            var res = await _repository.DeletePaymentTypeById(id);
            return Ok(res);
        }
    }
}
