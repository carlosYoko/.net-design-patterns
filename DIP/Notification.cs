namespace DIP
{
    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            this._messageService = messageService;
        }

        public void Notify(string message)
        {
            this._messageService.SendMessage(message);
        }
    }
}
