namespace DIP
{
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
}
