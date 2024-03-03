namespace DesignPattern;

public class PrototypePattern
{
    public static void Main()
    {
        Resume a = new Resume("大鸟");
        a.SetPersonalInfo("男", "29");
        a.SetWorkExperience("1998-2000", "XX公司");

        Resume b = (Resume)a.Clone();
        b.SetWorkExperience("1998-2006", "YY企业");

        Resume c = (Resume)a.Clone();
        c.SetPersonalInfo("男", "24");

        a.Display();
        b.Display();
        c.Display();
    }
}

class Resume : ICloneable
{
    private string name;
    private string sex;
    private string age;
    
    private WorExperience work;

    public Resume(string name)
    {
        this.name = name;
        work = new WorExperience();
    }
    
    private Resume(WorExperience work)
    {
        this.work = (WorExperience)work.Clone();
    }

    public void SetPersonalInfo(string sex, string age)
    {
        this.sex = sex;
        this.age = age;
    }

    public void SetWorkExperience(string workData, string company)
    {
        work.WorkData = workData;
        work.Company = company;
    }

    public void Display()
    {
        Console.WriteLine($"{name} {sex} {age}");
        Console.WriteLine($"工作经历：{work.WorkData} {work.Company}");
    }

    public object Clone()
    {
        Resume obj = new Resume(this.work);
        obj.name = this.name;
        obj.sex = this.sex;
        obj.age = this.age;
        return obj;
    }
}

class WorExperience
{
    public string WorkData { get; set; }

    public string Company { get; set; }

    public object Clone()
    {
        return (object)this.MemberwiseClone();
    }

}



