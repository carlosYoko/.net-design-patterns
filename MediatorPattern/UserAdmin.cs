namespace MediatorPattern;

public class UserAdmin : Colleague
{
    public UserAdmin(IMediator mediator) : base(mediator)
    {
    }

    public override void Receive(string message)
    {
        Console.WriteLine("El Admin recibe el mensaje: " + message);
    }
}