using Payment.WebAPI.Factory_Pattern.Models;

namespace Payment.WebAPI.Factory_Pattern.Services
{
    public interface IPayment
    {
        Task<PaymentResponseBuilder> PayAsync(PaymentRequest paymentRequest);
    }
}
