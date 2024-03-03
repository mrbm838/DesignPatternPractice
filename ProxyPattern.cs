namespace DesignMode;

public class ProxyPattern
{
    public static void Main()
    {
        SchoolGirl jiaojiao = new SchoolGirl();
        jiaojiao.Name = "李娇娇";

        Proxy daili = new Proxy(jiaojiao);
        daili.GiveDolls();
        daili.GiveFlowers();
        daili.GiveChocolate();

    }
}

public class SchoolGirl
{
    public string? Name { get; set; }
}

public interface IGiveGift
{
    void GiveDolls();
    void GiveFlowers();
    void GiveChocolate();
}

public class Pursuit : IGiveGift
{
    private SchoolGirl mm;
    public Pursuit(SchoolGirl mm)
    {
        this.mm = mm;
    }
    public void GiveDolls()
    {
        Console.WriteLine(mm.Name + " 送你洋娃娃");
    }
    public void GiveFlowers()
    {
        Console.WriteLine(mm.Name + " 送你鲜花");
    }
    public void GiveChocolate()
    {
        Console.WriteLine(mm.Name + " 送你巧克力");
    }
}

public class Proxy : IGiveGift
{
    Pursuit gg;
    public Proxy(SchoolGirl mm)
    {
        gg = new Pursuit(mm);
    }
    public void GiveDolls()
    {
        gg.GiveDolls();
    }
    public void GiveFlowers()
    {
        gg.GiveFlowers();
    }
    public void GiveChocolate()
    {
        gg.GiveChocolate();
    }
}


