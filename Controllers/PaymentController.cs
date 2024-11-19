using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.RequestResponse;
using OrderManagementSystem.Service;

namespace OrderManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IOMSSevice _repository;
        public PaymentController(IOMSSevice repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("getpayments")]
        public async Task<IActionResult> GetPayments()
        {
            var res = await _repository.GetPayments();
            return Ok(res);
        }

        [HttpGet]
        [Route("getpaymentbyid")]
        public async Task<IActionResult> GetPaymentById(Guid id)
        {
            var res = await _repository.GetPaymentById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addpayment")]
        public async Task<IActionResult> AddPayment(PaymentResponse payment)
        {
            var res = await _repository.AddPayment(payment);
            return Ok(res);
        }

        [HttpPut]
        [Route("updatepayment")]
        public async Task<IActionResult> UpdatePayment(Guid id, PaymentResponse payment)
        {
            var res = await _repository.UpdatePayment(id, payment);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deletepaymentbyid")]

        public async Task<IActionResult> DeletePaymentById(Guid id)
        {
            var res = await _repository.DeletePaymentById(id);
            return Ok(res);
        }
    }
}
