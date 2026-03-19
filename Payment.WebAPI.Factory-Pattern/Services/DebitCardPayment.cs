using Payment.WebAPI.Factory_Pattern.Models;

namespace Payment.WebAPI.Factory_Pattern.Services
{
    public class DebitCardPayment : IPayment
    {
        public async Task<PaymentResponseBuilder> PayAsync(PaymentRequest paymentRequest)
        {
            // Simulate some processing time
            await Task.Delay(1000);
            // Here you would implement the actual logic to process the debit card payment
            // For demonstration purposes, we'll just return a successful response
            return new PaymentResponseBuilder().WithPaymentType(paymentRequest.Type).WithPaymentStatus("Success");
        }
    }
}
