public class pattern5
{
    public void p5()
    {
        Console.WriteLine("Pattern 5");
        int count = 0;
        int n = 7;
        for (int i = 0; i <=n; i++)
        {

            for (int j = 0; j < i; j++)
            {
                count++;
                Console.Write(" "+count); 
            
            }
            Console.WriteLine();

        }
    
    }
}