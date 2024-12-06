public class Discount
{
    public int DiscountId { get; set; }
    public decimal DiscountAmount { get; set; }
    public DateTime ExpiryDate { get; set; }

    public void ApplyDiscount() { }
    public void CheckDiscountValidity() { }
}