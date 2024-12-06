public class Payment
{
    public int PaymentId { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public bool IsPaid { get; set; }

    public void ProcessPayment() { }
    public void RefundPayment() { }
    public void GetPaymentDetails() { }
    public void UpdatePaymentStatus() { }
}