public class Stackclass
{
        const int max = 4;
        int top;
        int[] stack = new int[max];
        int count = 0;

        public Stackclass()
        {
            top = -1;
        }
        public void push(int value)
        {
            if (top >= max -1 )
            {
               Console.WriteLine("\nStack is overflow !");
            }
            else
            {
                
                stack[++top] = value;
                
            }
        }

        public void pop() 
        {
            if (top <0)
            {
                Console.WriteLine("\nStack is Underflow !");
            }
            else {
                top--;
            }

        }

        public void peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Underflow !");
            }
            else
            {
                Console.WriteLine("\n Stack Top of:" + stack[top]);
            }
        }

        public void getStack()
        {
            if (top == -1)
            { 
                Console.WriteLine("Stack is empty !");    
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write(" " + stack[i]);
                }
            }
            
        }
}

  


