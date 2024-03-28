namespace MediatorPattern;

public class Mediator : IMediator
{
    private List<Colleague> _colleagues;

    public Mediator()
    {
        _colleagues = new List<Colleague>();
    }

    public void Add(Colleague colleague)
    {
        this._colleagues.Add(colleague);
    }

    public void Send(string message, Colleague colleague)
    {
        foreach (var c in this._colleagues)
        {
            if (colleague != c)
            {
                c.Receive(message);
            }
        }
    }
}