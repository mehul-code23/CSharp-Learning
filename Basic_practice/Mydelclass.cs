

namespace DemoApp1
{
    public delegate void Mydel(string msg);
    public class Mydelclass
    {
        public static void Hello(string msg)
        {
            Console.WriteLine("Hello," + msg);
        }

        public static void Bye(string msg)
        {
            Console.WriteLine("Bye," + msg);
        }

        // if we want to called delegates class so 
        // using DemoApp1.Mydelclass; add to Main.file 
    }
}

