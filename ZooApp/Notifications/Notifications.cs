public class Notification
{
    public int NotificationId { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }

    public void SendNotification() { }
    public void MarkAsRead() { }
}