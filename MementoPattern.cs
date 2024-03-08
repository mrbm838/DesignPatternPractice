namespace DesignPattern;

public class MementoPattern
{
    public static void Main()
    {
        Originator o = new Originator();
        o.State = "On";
        o.Show();

        Caretaker c = new Caretaker();
        c.Memento = o.CreateMemento();

        o.State = "Off";
        o.Show();

        o.SetMemento(c.Memento);
        o.Show();
    }

}

public class Originator
{
    public string State { get; set; }

    public Memento CreateMemento()
    {
        return new Memento(State);
    }

    public void SetMemento(Memento memento)
    {
        State = memento.State;
    }

    public void Show()
    {
        Console.WriteLine($"State = {State}");
    }
}

public class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}

public class Caretaker
{
    public Memento Memento { get; set; }
}

