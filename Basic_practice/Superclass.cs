public class Superclass
{
    public Superclass()
    {
        Console.WriteLine("This is Constructor");
    }
    public virtual void speak()
    {
        Console.WriteLine("This is superclass ");
    }
}

public class Subclass : Superclass
{
   
    
    public override void speak()
    {
        
        Console.WriteLine("This is subclass ");
    }
}