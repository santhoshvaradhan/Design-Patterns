using Payment.WebAPI.Factory_Pattern.Models;

namespace Payment.WebAPI.Factory_Pattern.Services
{
    /// <summary>
    /// Factory Class for Selecting which type of Object (payment instance)
    /// </summary>
    public class PaymentFactory
    {
       
        private readonly IServiceProvider _provider;

        private  IPayment? _payment;
        public PaymentFactory(IServiceProvider provider) 
        { 
            _provider = provider;
        }
        public async Task<PaymentResponseBuilder> PaymentProcess(PaymentRequest paymentRequest)
        {
            // Dynamic Selection?
            // Instead of hardcoding "UPI" and "Card" :

            _payment = _provider.GetKeyedService<IPayment>(paymentRequest.Type) ?? throw new Exception("InValid Payment Option");

             return await _payment.PayAsync(paymentRequest);
            
        }
    }
}
