namespace DesignPattern;

public class StatePattern
{
    public static void Main()
    {
        Context context = new Context(new ConcreteStateA());
        context.Hour = 9;
        context.Request();
        context.Hour = 10;
        context.Request();
        context.Hour = 12;
        context.Request();
        context.Hour = 13;
        context.Request();
        context.Hour = 14;
        context.Request();
        context.Hour = 15;
        context.Request();
        context.Hour = 16;
        context.Request();
        context.Hour = 17;
        context.Request();
        context.Hour = 18;
        context.Request();
        context.Hour = 19;
        context.Request();
        context.Hour = 20;
        context.Request();
        context.Hour = 21;
        context.Request();
        context.Hour = 22;
        context.Request();
        context.Hour = 23;
        context.Request();
        context.Hour = 24;
        context.Request();
        context.Hour = 1;
        context.Request();
        context.Hour = 2;
        context.Request();
        context.Hour = 3;
        context.Request();
        context.Hour = 4;
        context.Request();
        context.Hour = 5;
        context.Request();
        context.Hour = 6;
        context.Request();
        context.Hour = 7;
        context.Request();
        context.Hour = 8;
        context.Request();
    }
}

public interface IState
{
    void Handle(Context context);
}

public class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        if (context.Hour < 12)
        {
            Console.WriteLine("ConcreteStateA handles request1. {0}", context.Hour);
        }
        else
        {
            context.TransitionTo(new ConcreteStateB());
            context.Request();
        }
    }
}

public class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        if (context.Hour < 12)
        {
            context.TransitionTo(new ConcreteStateA());
            context.Request();
        }
        else
        {
            if (context.TaskFinished)
            {
                Console.WriteLine("TaskFinished. {0}", context.Hour);
            }
            else
            {
                Console.WriteLine("TaskFinished. {0}", context.Hour);
            }
        }
    }
}

public class Context
{
    private IState _state = null;

    public int Hour { get; set; }

    public bool TaskFinished { get; set; }

    public Context(IState state)
    {
        this.TransitionTo(state);
    }

    public void TransitionTo(IState state)
    {
        Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        this._state = state;
    }

    public void Request()
    {
        this._state.Handle(this);
    }
}
