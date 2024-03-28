namespace MediatorPattern;

public interface IMediator
{
    void Send(string message, Colleague colleague);
}