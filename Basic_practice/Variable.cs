

public class Variable
{
    public readonly int a = 200;
    public static int b = 100;
    public void display()
    {
        Console.WriteLine("A :"+a);
    }
}

public class Demo
{
    public static string  update() {
        //Variable.b = 200;
       
        return "Here Static method called ";
    }
    
    public static void display()
    {
       
        Console.WriteLine("B :" + Variable.b);
    }
}
