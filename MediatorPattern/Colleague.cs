namespace MediatorPattern;

public abstract class Colleague
{
    private IMediator _mediator;

    public Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void Communicate(string message)
    {
        this._mediator.Send(message, this);
    }

    public abstract void Receive(string message);
}