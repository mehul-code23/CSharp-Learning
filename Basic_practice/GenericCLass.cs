public class Casting<T>
{
    private T value;

    public void Add(T item)
    { 
        value = item;
    }

    public T getValue() 
    {
        return value;
    }
    
}
