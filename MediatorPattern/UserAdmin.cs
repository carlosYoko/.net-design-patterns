namespace MediatorPattern;

public class UserAdmin : Colleague
{
    public string? UserName { get; set; }
    public UserAdmin(IMediator mediator, string userName) : base(mediator)
    {
        UserName = userName;
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"El Admin {UserName} recibe el mensaje: " + message);
    }
}