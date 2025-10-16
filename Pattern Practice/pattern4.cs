public class pattern4
{
    public void p4()
    {
        Console.WriteLine("Pattern 4");
        int n = 5;
        for (int i = 0; i <=n; i++)
        {
            if (i == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }

            }
            else
            {
                for(int j = i;  j< n; j++)
                {
                    if (j == i)
                    {
                        Console.Write("* ");
                    }
                    else if ((n - 1) == j)
                    {
                        Console.Write("* ");
                    }
                    else {
                        Console.Write("  ");
                    }
                }

            }


                Console.WriteLine();
        }
    }
    
}