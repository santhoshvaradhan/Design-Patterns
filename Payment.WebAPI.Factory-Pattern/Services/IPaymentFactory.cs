using Payment.WebAPI.Factory_Pattern.Models;

namespace Payment.WebAPI.Factory_Pattern.Services
{
    /// <summary>
    /// Factory Class for Selecting which type of Object (payment instance)
    /// </summary>
    public interface IPaymentFactory
    {
        public Task<PaymentResponseBuilder> PaymentProcess(PaymentRequest paymentRequest);
    }
}
