public class pattern9
{
    public void p9()
    {
        Console.WriteLine("Pattern 9 ");
       
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i==0)
                {
                    Console.Write("* ");
                }
                else if ((n-1)== j)
                {
                    Console.Write("* ");
                }
                else 
                { 
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine();
        }
    }

}