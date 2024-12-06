public class Ticket
{
    public int TicketId { get; set; }
    public DateTime IssueDate { get; set; }
    public decimal Price { get; set; }
    public string TicketType { get; set; }

    public void GenerateTicket() { }
    public void ViewTicket() { }
    public void CancelTicket() { }
    public void GetTicketDetails() { }
}