
public abstract class Myclass
{
    public static string name = "mehul";

    public static void printValue()
    { 
        Console.WriteLine(name);
    }
}

public interface Methods
{
    const int a = 10;
    void print();

    abstract void display();
}
public class Subclass1 : Myclass  , Methods
{
    public void print()
    {
        Myclass.printValue();
        Console.WriteLine("This interface called method");
    }

    public void display()
    {
        Console.WriteLine("This is a abstract method called");
    }
}