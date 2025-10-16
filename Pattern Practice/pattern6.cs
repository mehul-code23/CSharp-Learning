public class pattern6
{
    public void p6()
    {
        Console.WriteLine("Pattern 6");
        int n = 5;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write((i+2));
            }
            Console.WriteLine();
        }

        for (int i = n; i >=3; i--)
        {
            for (int j = 0; j < i-2; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine() ;
        }
    }

}