using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Pattern_Practice
{
    internal class pattern3
    {
        public void p3() {
            Console.WriteLine("Pattern 3 ");

            for (int i = 0; i <= 5; i++)
            {
                for (int k = i;k <5;k ++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
