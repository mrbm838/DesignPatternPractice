namespace DesignPattern;

public class FlyweightPattern
{
    public static void Main(string[] args)
    {
        WebSiteFactory f = new WebSiteFactory();

        WebSite fx = f.GetWebSiteCategory("产品展示");
        fx.Use();

        WebSite fy = f.GetWebSiteCategory("产品展示");
        fy.Use();

        WebSite fz = f.GetWebSiteCategory("产品展示");
        fz.Use();

        WebSite fl = f.GetWebSiteCategory("博客");
        fl.Use();

        WebSite fm = f.GetWebSiteCategory("博客");
        fm.Use();

        WebSite fn = f.GetWebSiteCategory("博客");
        fn.Use();

        Console.WriteLine("网站分类总数为：" + f.GetWebSiteCount());
    }
}

abstract class WebSite
{
    public abstract void Use();
}

class ConcreteWebSite : WebSite
{
    private string name;

    public ConcreteWebSite(string name)
    {
        this.name = name;
    }

    public override void Use()
    {
        Console.WriteLine("网站分类：" + name);
    }
}

class WebSiteFactory
{
    private Dictionary<string, WebSite> flyweights = new Dictionary<string, WebSite>();

    public WebSite GetWebSiteCategory(string key)
    {
        if (!flyweights.ContainsKey(key))
        {
            flyweights.Add(key, new ConcreteWebSite(key));
        }
        return flyweights[key];
    }

    public int GetWebSiteCount()
    {
        return flyweights.Count;
    }
}
