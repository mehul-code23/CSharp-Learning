public class pattern7
{
    public void p7()
    {
        Console.WriteLine("Pattern 7");
        int n = 5;
        for (int i = 0; i <=    n; i++)
        {
            for (int j = 0; j < i; j++)
            {
               Console.Write(i);
                if (i >= 1 && j<i-1)
                {
                    Console.Write("*");
                }  
            }
            Console.WriteLine();
        }
        for (int i = n; i >=0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
                if (i <= n && j<i-1 )
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

    }

}
