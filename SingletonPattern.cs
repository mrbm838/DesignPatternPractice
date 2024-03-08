namespace DesignPattern;

public class SingletonPattern
{
    public static void Main()
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        if (s1 == s2)
        {
            Console.WriteLine("s1 与 s2 是相同的实例");
        }
    }
}

// lazy initialization
public class Singleton
{
    private static Singleton? instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

// eager initialization
public class SingletonEager
{
    private static SingletonEager instance = new SingletonEager();

    private SingletonEager() { }

    public static SingletonEager Instance => instance;
}

// double-checked locking
public class SingletonDoubleChecked
{
    private static SingletonDoubleChecked? instance;
    private static readonly object syncRoot = new object();

    private SingletonDoubleChecked() { }

    public static SingletonDoubleChecked Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SingletonDoubleChecked();
                    }
                }
            }
            return instance;
        }
    }
}