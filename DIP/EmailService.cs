namespace DIP
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
