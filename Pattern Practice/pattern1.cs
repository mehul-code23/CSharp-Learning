public class pattern1
{ 
    public void p1()
    {
        Console.WriteLine("Pattern 1 :");
        for (int i = 0; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");  
            }
            Console.WriteLine();
        }

    }

}