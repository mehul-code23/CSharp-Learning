public class pattern2
{
    public void p2()
    {
        Console.WriteLine("Pattern 2");
        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < 5; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}