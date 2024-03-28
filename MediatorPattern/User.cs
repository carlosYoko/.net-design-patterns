namespace MediatorPattern;

public class User : Colleague
{
    public string? UserName { get; set; }
    public User(IMediator mediator, string userName) : base(mediator)
    {
        UserName = userName;
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"El usuario {UserName} recibe el mensaje: " + message);
    }
}