namespace DesignPattern;

public class InterpretPattern
{
    public static void Main(string[] args)
    {
        PlayContext context = new PlayContext();
        context.Input = "a b c a b c a b c";
        context.Output = "";

        List<AbstractExpression> list = new List<AbstractExpression>();
        list.Add(new TerminalExpression());
        list.Add(new NonterminalExpression());
        list.Add(new TerminalExpression());
        list.Add(new TerminalExpression());

        foreach (AbstractExpression exp in list)
        {
            exp.Interpret(context);
        }

        Console.WriteLine(context.Output);
    }
}

class PlayContext
{
    private string input;
    private string output;

    public string Input
    {
        get { return input; }
        set { input = value; }
    }

    public string Output
    {
        get { return output; }
        set { output = value; }
    }
}

abstract class AbstractExpression
{
    public abstract void Interpret(PlayContext context);
}

class TerminalExpression : AbstractExpression
{
    public override void Interpret(PlayContext context)
    {
        if (context.Input.StartsWith("a"))
        {
            context.Output = "1";
        }
        else if (context.Input.StartsWith("b"))
        {
            context.Output = "2";
        }
        else if (context.Input.StartsWith("c"))
        {
            context.Output = "3";
        }
    }
}

class Nonterminal
{
    public void Interpret(PlayContext context)
    {
        if (context.Input.StartsWith("a b"))
        {
            context.Output = "4";
            context.Input = context.Input.Substring(2);
        }
        else if (context.Input.StartsWith("a c"))
        {
            context.Output = "5";
            context.Input = context.Input.Substring(2);
        }
    }
}
