using Payment.WebAPI.Factory_Pattern.Models;

namespace Payment.WebAPI.Factory_Pattern.Services
{
    public class UPIPayment : IPayment
    {
        public UPIPayment() { }

        public async Task<PaymentResponseBuilder> PayAsync(PaymentRequest paymentRequest)
        {
            await Task.Delay(1000);
            Console.WriteLine("UPI");
            return new PaymentResponseBuilder().WithPaymentType(paymentRequest.Type);
        }
    }
}
