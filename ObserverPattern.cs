namespace DesignPattern;

public class ObserverPattern
{
    public static void Main()
    {
        ConcreteSubject subject = new();
        subject.Attach(new ConcreteObserver(subject, "X"));
        subject.Attach(new ConcreteObserver(subject, "Y"));
        subject.Attach(new ConcreteObserver(subject, "Z"));

        subject.SubjectState = "ABC";
        subject.Notify();

        Console.ReadLine();
    }
}

abstract class Subject
{
    private List<Observer> _observers = new();

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

class ConcreteSubject : Subject
{
    private string? _subjectState;

    public string? SubjectState
    {
        get => _subjectState;
        set => _subjectState = value;
    }
}

abstract class Observer
{
    public abstract void Update();
}

class ConcreteObserver(ConcreteSubject subject, string name) : Observer
{
    private string _name = name;
    private string? _observerState;
    private ConcreteSubject _subject = subject;

    public override void Update()
    {
        _observerState = _subject.SubjectState;
        Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
    }

    public ConcreteSubject Subject
    {
        get => _subject;
        set => _subject = value;
    }
}