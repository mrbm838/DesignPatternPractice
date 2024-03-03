namespace DesignMode;

public class SampleFactoryPatten
{
    public static void Main()
    {
        Operation oper;
        oper = OperationFactory.CreateOperation("+");
        oper.NumberA = 1;
        oper.NumberB = 2;
        Console.WriteLine(oper.GetResult());
    }
}

public class Operation
{
    public double NumberA { get; set; }
    public double NumberB { get; set; }

    public virtual double GetResult()
    {
        double result = 0;
        return result;
    }
}

public class OperationAdd : Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA + NumberB;
        return result;
    }
}

public class OperationSub : Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA - NumberB;
        return result;
    }
}

public class OperationMul : Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA * NumberB;
        return result;
    }
}

public class OperationDiv : Operation
{
    public override double GetResult()
    {
        double result = 0;
        if (NumberB == 0)
            throw new Exception("除数不能为0");
        result = NumberA / NumberB;
        return result;
    }
}

public class OperationFactory
{
    public static Operation CreateOperation(string operate)
    {
        Operation? oper = null;
        switch (operate)
        {
            case "+":
                oper = new OperationAdd();
                break;
            case "-":
                oper = new OperationSub();
                break;
            case "*":
                oper = new OperationMul();
                break;
            case "/":
                oper = new OperationDiv();
                break;
            default:
                throw new ArgumentException("Invalid operation");
        }
        return oper;
    }
}
