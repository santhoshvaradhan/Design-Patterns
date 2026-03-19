using Microsoft.AspNetCore.Mvc;
using Payment.WebAPI.Factory_Pattern.Models;
using Payment.WebAPI.Factory_Pattern.Services;

namespace Payment.WebAPI.Factory_Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase 
    {

        private readonly ILogger<PaymentController> _logger;

        private readonly PaymentFactory _paymentFactory;

        public PaymentController(ILogger<PaymentController> logger,PaymentFactory paymentFactory)
        {
            _logger = logger;
            _paymentFactory = paymentFactory;
        }

        [HttpPost]
        public async Task<IActionResult> PaymentAsync(PaymentRequest paymentRequest)
        {
            var result = await _paymentFactory.PaymentProcess(paymentRequest);

            return Ok(result);
        }

       
    }
}
