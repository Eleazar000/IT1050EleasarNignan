using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Homework
{
    class Program
    {
        const string STAR = "*";
        const string SPACE = " ";
        const int Counter = 10;

        static void Main(string[] args)
        {
            int i = 1;
             while (i <= 9)
             {
                 Console.WriteLine(i);
                 i = i + 2;
             }
             // counter= i
             // loop control variable= i=1
             //loop terminating condition= i<=9
             //loop variable modification= i+2
              

            /*int i;
            for ( i = 30; i <= 45; i++)
            {
                Console.WriteLine(i);
                if ((i % 2) == 0)
                {
                    Console.WriteLine("It's even");
                }
                else
                {
                    Console.WriteLine("it's odd");
                }
            }

            int time;

            Console.WriteLine("Enter time");
            time = Convert.ToInt32(Console.ReadLine());

            if (time <= 11)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time <=16)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (time<=24)
            {
                Console.WriteLine("Good Evening");
            }
            

            // 4. The loop variable needed to be modified
            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            

            // 5. The brackets were missing

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
            
            // 6. 

            int i = 5;
            do
            {
                int space = i;
                do
                {
                    Console.Write(' ');
                    space--;
                } while (space >= 1);
                int j = 5;
                do
                {
                    Console.Write("* ");
                    j--;
                } while (j >= i);
                Console.WriteLine();
                i--;
            } while (i >= 1);
              Console.Read();
            */

 
        
            Display();
            Console.ReadLine();

        }
        static public void Display()
        {
            for (int r = 0; r < Counter; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    Console.Write(STAR);
                }
                Console.WriteLine();
            }
        }
    }
}
        