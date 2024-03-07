namespace DesignPattern;

public class AdapterPattern
{
    public static void Main()
    {
        Player b = new Forwards("巴蒂尔");
        b.Attack();

        Player m = new Center("麦克格雷迪");
        m.Attack();

        Player ym = new Translator("姚明");
        ym.Attack();
        ym.Defense();
    }
}

abstract class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        Name = name;
    }

    public abstract void Attack();
    public abstract void Defense();
}

class Forwards(string name) : Player(name)
{
    public override void Attack()
    {
        Console.WriteLine($"前锋 {Name} 进攻");
    }

    public override void Defense()
    {
        Console.WriteLine($"前锋 {Name} 防守");
    }
}

class Center(string name) : Player(name)
{
    public override void Attack()
    {
        Console.WriteLine($"中锋 {Name} 进攻");
    }

    public override void Defense()
    {
        Console.WriteLine($"中锋 {Name} 防守");
    }
}

class ForeignCenter
{
    public required string Name { get; set; }
    public void 进攻()
    {
        Console.WriteLine($"外籍中锋 {Name} 进攻");
    }

    public void 防守()
    {
        Console.WriteLine($"外籍中锋 {Name} 防守");
    }
}

class Translator : Player
{
    private ForeignCenter wjzf;

    public Translator(string name) : base(name) => wjzf = new ForeignCenter { Name = name };

    public override void Attack()
    {
        wjzf.进攻();
    }

    public override void Defense()
    {
        wjzf.防守();
    }
}