public class pattern8
{
    public void p8()
    {
        Console.WriteLine("Pattern 8");


        int n = 5;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                count++;
                Console.Write(count);
                if (i < n && j < i - 1)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            
        }




    }
}