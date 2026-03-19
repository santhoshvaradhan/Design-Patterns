namespace Payment.WebAPI.Factory_Pattern.Models
{
    /// <summary>
    /// Builder pattern
    /// Creating Complex Objects
    /// </summary>
    public class PaymentResponseBuilder
    {
        public string? PaymentType { get; set; }
        public string? Status { get; set; } = "Success";
        public PaymentResponseBuilder() { }

        public PaymentResponseBuilder WithPaymentType(string? paymentType)
        {
            PaymentType = paymentType;
            return this;
        }

        public PaymentResponseBuilder WithPaymentStatus(string? status)
        {
            Status = status;
            return this;
        }
    }
}
