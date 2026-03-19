using Payment.WebAPI.Factory_Pattern.Models;

namespace Payment.WebAPI.Factory_Pattern.Services
{
    public class CreditCardPayment : IPayment
    {
        public CreditCardPayment() { }

        public async Task<PaymentResponseBuilder> PayAsync(PaymentRequest paymentRequest)
        {
            if (paymentRequest == null)
            {
                throw new ArgumentNullException(nameof(paymentRequest));
            }
            await Task.Delay(1000);
            Console.WriteLine("CreditCard");
            return new PaymentResponseBuilder().WithPaymentType("CreditCardPayment").WithPaymentStatus("Success");
        }
    }
}
