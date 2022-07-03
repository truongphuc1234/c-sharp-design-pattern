namespace CORStructure;

interface IHandler
{
    public void SetNext(IHandler handler);
    public void Handle(object request);
}

abstract class BaseHandler : IHandler
{
    protected IHandler next;

    public virtual void Handle(object request)
    {
        if (next != null)
        {
            next.Handle(request);
        }
    }

    public void SetNext(IHandler handler)
    {
        next = handler;
    }
}

class ConcreteHandlerA : BaseHandler
{
    public override void Handle(object request)
    {
        Console.WriteLine("Handler A handle");
        base.Handle(request);
    }
}
class ConcreteHandlerB : BaseHandler
{
    public override void Handle(object request)
    {
        Console.WriteLine("Handler B Handle");
        base.Handle(request);
    }
}
class COncreteHandlerC : BaseHandler
{
    public override void Handle(object request)
    {
        Console.WriteLine("Handler C Handle");
        base.Handle(request);
    }
}