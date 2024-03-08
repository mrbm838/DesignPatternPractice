namespace DesignPattern;

public class IteratorPattern
{
    public static void Main()
    {
        ConcreteAggregate a = new ConcreteAggregate();
        IIterator i = new ConcreteIterator(a);

        object item = i.First();
        while (!i.IsDone())
        {
            Console.WriteLine($"{i.CurrentItem()} 请买车票！");
            i.Next();
        }
    }
}

public interface IIterator
{
    object First();
    object Next();
    bool IsDone();
    object CurrentItem();
}

public interface IAggregate
{
    IIterator CreateIterator();
}

public class ConcreteAggregate : IAggregate
{
    private object[] items;

    public ConcreteAggregate()
    {
        items = new object[] { "大鸟", "小菜", "行李", "老外", "公交内部员工", "小偷" };
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count => items.Length;

    public object this[int index]
    {
        get => items[index];
        set => items[index] = value;
    }
}

public class ConcreteIterator : IIterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public object First()
    {
        return aggregate[0];
    }

    public object Next()
    {
        object ret = null;
        current++;
        if (current < aggregate.Count)
        {
            ret = aggregate[current];
        }
        return ret;
    }

    public bool IsDone()
    {
        return current >= aggregate.Count;
    }

    public object CurrentItem()
    {
        return aggregate[current];
    }
}
