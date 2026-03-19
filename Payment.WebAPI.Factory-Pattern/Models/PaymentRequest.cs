namespace Payment.WebAPI.Factory_Pattern.Models
{

    /// <summary>
    /// This model for testing and understanding purpose
    /// </summary>
    public class PaymentRequest
    {
        public required string Type { get; set; }
        public required decimal Amount { get; set; }
    }
}
